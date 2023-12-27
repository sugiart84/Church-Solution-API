using Church_Solution_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;

namespace Church_Solution_API.Helpers.DataSeeding
{
    public class Sampledata
    {
        public static void Initialize(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            //var context = serviceProvider.GetService<ApplicationDbContext>();

            string[] roles = new string[] { "Admin", "Administrator" };

            foreach (string role in roles)
            {
                var roleStore = new RoleStore<IdentityRole>(context);

                if (!context.Roles.Any(r => r.Name == role))
                {
                    roleStore.CreateAsync(new IdentityRole(role));
                }
            }


            var user = new ApplicationUser
            {
                Email = "administrator@email.com",
                NormalizedEmail = "administrator@email.com",
                UserName = "administrator",
                NormalizedUserName = "administrator",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };


            if (!context.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, "Admin_123");
                user.PasswordHash = hashed;

                var userStore = new UserStore<ApplicationUser>(context);
                var result = userStore.CreateAsync(user);

            }

            AssignRoles(app.Services, user.Email, roles);
            string namaSpaceid = Guid.NewGuid().ToString();
            var findNameSpace = context.PermissionNamespace.Where(c=>c.Name == "PermissionNamespace").FirstOrDefault();
            if(findNameSpace == null)
            {
                var namaSpaceModel = new PermissionNamespace
                {
                    PermissionNamespaceId = namaSpaceid,
                    Name = "PermissionNamespace",
                    CreatedBy = user.Id,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                };
            }

            string actionid_create = Guid.NewGuid().ToString();
            string actionid_read = Guid.NewGuid().ToString();
            string actionid_update = Guid.NewGuid().ToString();
            var findActionRead = context.PermissionAction.Where(c => c.Name == "read").FirstOrDefault();
            if (findActionRead == null)
            {
                var namaSpaceModel = new PermissionAction
                {
                    PermissionActionId = actionid_read,
                    Name = "read",
                    CreatedBy = user.Id,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                };
            }

            var findActionCreate = context.PermissionAction.Where(c => c.Name == "create").FirstOrDefault();
            if (findActionCreate == null)
            {
                var namaSpaceModel = new PermissionAction
                {
                    PermissionActionId = actionid_create,
                    Name = "create",
                    CreatedBy = user.Id,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                };
            }

            var findActionUpdate = context.PermissionAction.Where(c => c.Name == "update").FirstOrDefault();
            if (findActionUpdate == null)
            {
                var namaSpaceModel = new PermissionAction
                {
                    PermissionActionId = actionid_update,
                    Name = "update",
                    CreatedBy = user.Id,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                };
            }

            context.SaveChangesAsync();

            var findRole = context.Roles.Where(c => c.Name == "Administrator").FirstOrDefault();
            if (findRole != null)
            {
                var namaSpaceModelRead = new PermissionRoleAssigment
                {
                    PermissionRoleAssigmentId = Guid.NewGuid().ToString(),
                    PermissionActionId = actionid_read,
                    PermissionNamespaceId = namaSpaceid,
                    RoleId = findRole.Id
                };
                context.PermissionRoleAssigment.Add(namaSpaceModelRead);
                var namaSpaceModelCreate = new PermissionRoleAssigment
                {
                    PermissionRoleAssigmentId = Guid.NewGuid().ToString(),
                    PermissionActionId = actionid_create,
                    PermissionNamespaceId = namaSpaceid,
                    RoleId = findRole.Id
                };
                context.PermissionRoleAssigment.Add(namaSpaceModelCreate);
                context.SaveChangesAsync();
            }
        }

        public static async Task<IdentityResult> AssignRoles(IServiceProvider services, string email, string[] roles)
        {
            UserManager<ApplicationUser> _userManager = services.GetService<UserManager<ApplicationUser>>();
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            var result = await _userManager.AddToRolesAsync(user, roles);

            return result;
        }
    }
}
