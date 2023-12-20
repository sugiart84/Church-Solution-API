using Church_Solution_API.Helpers.Permission;
using Church_Solution_API.Models;
using Church_Solution_API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Church_Solution_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        public AccountController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, ApplicationDbContext _db)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
            db = _db;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(RegistrationModel model)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return BadRequest("User already exists");

            ApplicationUser user = new()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username,
                FullName = model.FullName
            };
            var createUserResult = await userManager.CreateAsync(user, model.Password);
            if (!createUserResult.Succeeded)
                return BadRequest("User creation failed! Please check user details and try again.");

            if (!await roleManager.RoleExistsAsync(model.Role))
                await roleManager.CreateAsync(new IdentityRole(model.Role));

            if (await roleManager.RoleExistsAsync(model.Role))
                await userManager.AddToRoleAsync(user, model.Role);

            return Ok("User created successfully!");
        }

        [HttpGet]
        [Route("GetFamily")]
        [ClaimRequirement("account:read")]
        public ActionResult GetFamily()
        {
            string userid = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
            string fname = User.FindFirstValue(ClaimTypes.GivenName) ?? string.Empty;
            var mdlFamily = db.FamilyModel.ToList();
            var mdlFamilyMember = db.FamilyMemberModel.ToList();
            //var findPremiumAutomation = (from f in mdlFamily
            //                             orderby f.JointDate descending
            //                             select new FamilyModel
            //                             {
            //                                 FamilyCode = f.FamilyName,
            //                                 ProviderIcon = f.ProviderIcon,
            //                                 ProviderName = pv.Name,
            //                                 Description = pr.PlanName,
            //                                 PremiumAmount = pr.PremiumAmount,
            //                             }).Distinct().OrderBy(c => c.PremiumAmount).ToList();
            return Ok(mdlFamilyMember);
        }
    }
}
