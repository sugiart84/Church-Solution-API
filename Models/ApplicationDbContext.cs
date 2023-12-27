using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

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

            string userid = Guid.NewGuid().ToString();
            string roleid = Guid.NewGuid().ToString();
            string namespaceid = Guid.NewGuid().ToString();
            string actionreadid = Guid.NewGuid().ToString();
            string actioncreateid = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userid, // primary key
                    UserName = "admin@mail.com",
                    NormalizedUserName = "ADMIN@MAIL.COM",
                    Email = "admin@mail.com",
                    NormalizedEmail = "ADMIN@MAIL.COM",
                    FullName = "Super Admin",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin_123")
                }
            );

            modelBuilder.Entity<IdentityRole>().HasData(new List<IdentityRole>
            {
                new IdentityRole {
                    Id = roleid,
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roleid,
                    UserId = userid
                }
            );

            modelBuilder.Entity<PermissionNamespace>().HasData(
                new PermissionNamespace
                {
                    PermissionNamespaceId = namespaceid,
                    CreatedBy = userid,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                    Name = "PermissionNamespace"
                }
            );
            modelBuilder.Entity<PermissionAction>().HasData(
                new PermissionAction
                {
                    PermissionActionId = actionreadid,
                    Name = "read",
                    CreatedBy = userid,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                }
            );
            modelBuilder.Entity<PermissionAction>().HasData(
                new PermissionAction
                {
                    PermissionActionId = actioncreateid,
                    Name = "create",
                    CreatedBy = userid,
                    CreatedDate = DateTime.Now,
                    isActive = true,
                }
            );
            modelBuilder.Entity<PermissionRoleAssigment>().HasData(
                new PermissionRoleAssigment
                {
                    PermissionRoleAssigmentId = Guid.NewGuid().ToString(),
                    PermissionActionId = actionreadid,
                    PermissionNamespaceId = namespaceid,
                    RoleId = roleid
                }
            );
            modelBuilder.Entity<PermissionRoleAssigment>().HasData(
                new PermissionRoleAssigment
                {
                    PermissionRoleAssigmentId = Guid.NewGuid().ToString(),
                    PermissionActionId = actioncreateid,
                    PermissionNamespaceId = namespaceid,
                    RoleId = roleid
                }
            );
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
