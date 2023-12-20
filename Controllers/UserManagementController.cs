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
    public class UserManagementController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IConfiguration configuration;
        public UserManagementController(UserManager<ApplicationUser> _userManager, IConfiguration _configuration, ApplicationDbContext _db) 
        {
            userManager = _userManager;
            configuration = _configuration;
            db = _db;
        }

        [HttpPost]
        [Route("menu-assigment")]
        public IActionResult GetMenuAssigment()
        {
            string userid = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
            var mdlMenuAssigment = db.MenuUserAssigment.ToList();
            return Ok(mdlMenuAssigment);
        }
    }
}
