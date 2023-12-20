using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church_Solution_API.Migrations
{
    /// <inheritdoc />
    public partial class POUKDB_v05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuPattern",
                columns: table => new
                {
                    MenuId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    PageId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isParent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isMaster = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuPattern", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "MenuUserAssigment",
                columns: table => new
                {
                    MenuRoleAssigmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MenuId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuUserAssigment", x => x.MenuRoleAssigmentId);
                });

            migrationBuilder.CreateTable(
                name: "PermissionAction",
                columns: table => new
                {
                    PermissionActionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionAction", x => x.PermissionActionId);
                });

            migrationBuilder.CreateTable(
                name: "PermissionNamespace",
                columns: table => new
                {
                    PermissionNamespaceId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionNamespace", x => x.PermissionNamespaceId);
                });

            migrationBuilder.CreateTable(
                name: "PermissionRoleAssigment",
                columns: table => new
                {
                    PermissionRoleAssigmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionPageId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionActionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionRoleAssigment", x => x.PermissionRoleAssigmentId);
                });

            migrationBuilder.CreateTable(
                name: "PermissionUserAssigment",
                columns: table => new
                {
                    PermissionUserAssigmentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionPageId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionActionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionUserAssigment", x => x.PermissionUserAssigmentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuPattern");

            migrationBuilder.DropTable(
                name: "MenuUserAssigment");

            migrationBuilder.DropTable(
                name: "PermissionAction");

            migrationBuilder.DropTable(
                name: "PermissionNamespace");

            migrationBuilder.DropTable(
                name: "PermissionRoleAssigment");

            migrationBuilder.DropTable(
                name: "PermissionUserAssigment");
        }
    }
}
