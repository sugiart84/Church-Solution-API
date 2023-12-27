using Microsoft.AspNetCore.Identity;

namespace Church_Solution_API.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool AccountActive { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
