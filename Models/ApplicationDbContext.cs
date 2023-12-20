using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Church_Solution_API.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string, IdentityUserClaim<string>, IdentityUserRole<string>,
    IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public DbSet<IdentityRole> RolesAssigment { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>(entity => { entity.ToTable(name: "Users"); });
            modelBuilder.Entity<IdentityRole>(entity => { entity.ToTable(name: "RolesAssigment"); });
            modelBuilder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRolesAssigment"); });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaimsAssigment"); });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLoginsAssigment"); });
            modelBuilder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokensAssigment"); });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaimsAssigment"); });
        }

        public DbSet<FamilyModel> FamilyModel { get; set; }
        public DbSet<FamilyMemberModel> FamilyMemberModel { get; set; }
        public DbSet<MajelisTypeModel> MajelisTypeModel { get; set; }
        public DbSet<MajelisPeriodModel> MajelisPeriodModel { get; set; }
        public DbSet<MajelisModel> MajelisModel { get; set; }
        public DbSet<MenuPattern> MenuPattern { get; set; }
        public DbSet<MenuDesign> MenuDesign { get; set; }
        public DbSet<MenuDesignDetail> MenuDesignDetail { get; set; }
        public DbSet<MenuUserAssigment> MenuUserAssigment { get; set; }
        public DbSet<PermissionNamespace> PermissionNamespace { get; set; }
        public DbSet<PermissionAction> PermissionAction { get; set; }
        public DbSet<PermissionRoleAssigment> PermissionRoleAssigment { get; set; }
        public DbSet<PermissionUserAssigment> PermissionUserAssigment { get; set; }
    }
}
