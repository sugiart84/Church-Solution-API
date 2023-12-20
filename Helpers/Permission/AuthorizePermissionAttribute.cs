using Church_Solution_API.Models;
using Jose;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Church_Solution_API.Helpers.Permission
{
    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(string claimValue) : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { new Claim(claimValue, claimValue) };
        }
    }

    public class ClaimRequirementFilter : IAuthorizationFilter
    {
        readonly Claim _claim;

        public ClaimRequirementFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            bool allowOpen = false;
            var isAuthorized = context.HttpContext.User.Identity.IsAuthenticated;
            if (isAuthorized && (!string.IsNullOrWhiteSpace(_claim.Value) || !string.IsNullOrWhiteSpace(_claim.Value)))
            {
                var userId = context.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (!string.IsNullOrWhiteSpace(_claim.Value))
                {
                    allowOpen = PermissionHelper.AllowToOpen(_claim.Value, context);
                }
            }
            if (!allowOpen)
            {
                context.Result = new ForbidResult();
            }
        }
    }
    public class GenerateSecretKey
    {
        public static string SecretKey()
        {
            var payload = new Dictionary<string, object>()
            {
                { "sub", "synergy.com.sg" },
                { "exp", 1300819380 }
            };

            var secretKey = new byte[] { 164, 60, 194, 0, 161, 189, 41, 38, 130, 89, 141, 164, 45, 170, 159, 209, 69, 137, 243, 216, 191, 131, 47, 250, 32, 107, 231, 117, 37, 158, 225, 234 };

            string token = Jose.JWT.Encode(payload, secretKey, JwsAlgorithm.HS256);
            return token;
        }
    }

    public class PermissionHelper
    {
        public static bool AllowToOpen(string Permission, AuthorizationFilterContext context)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();
            var connString = appSettings.GetValue<string>("ConnectionStrings:DefaultConnection");
            optionsBuilder.UseSqlServer(connString);
            using (ApplicationDbContext db = new ApplicationDbContext(optionsBuilder.Options))
            {
                bool result = false;
                string userid = context.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
                if (!string.IsNullOrEmpty(Permission))
                {
                    string[] array = Permission.Split(':');
                    if (array != null)
                    {
                        string page = array[0];
                        string action = array[1];
                        var mdlPermissionNamespace = db.PermissionNamespace.Where(c => c.Name.ToLower() == page.ToLower()).FirstOrDefault();
                        if (mdlPermissionNamespace != null)
                        {
                            var mdlAction = db.PermissionAction.Where(c => c.Name.ToLower() == action.ToLower()).FirstOrDefault();
                            if (mdlAction != null)
                            {
                                var LsRoleId = db.UserRoles.Where(c => c.UserId == userid).Select(c => c.RoleId).ToList();
                                var mdlPermissionRole = db.PermissionRoleAssigment.Where(c => LsRoleId.Contains(c.RoleId)).ToList();
                                var findRolePermission = mdlPermissionRole.Where(c => c.PermissionNamespaceId == mdlPermissionNamespace.PermissionNamespaceId && c.PermissionActionId == mdlAction.PermissionActionId).FirstOrDefault();
                                if (findRolePermission != null)
                                {
                                    result = true;
                                }
                                else
                                {
                                    var mdlPermissionUser = db.PermissionUserAssigment.Where(c => c.UserId == userid && c.PermissionNamespaceId == mdlPermissionNamespace.PermissionNamespaceId && c.PermissionActionId == mdlAction.PermissionActionId).FirstOrDefault();
                                    if (mdlPermissionUser != null)
                                    {
                                        result = true;
                                    }
                                }
                            }
                        }
                    }
                }
                return result;
            }
            
        }
    }
}
