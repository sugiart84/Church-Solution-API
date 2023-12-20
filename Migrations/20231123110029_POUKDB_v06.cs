using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church_Solution_API.Migrations
{
    /// <inheritdoc />
    public partial class POUKDB_v06 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PermissionPageId",
                table: "PermissionUserAssigment",
                newName: "PermissionNamespaceId");

            migrationBuilder.RenameColumn(
                name: "PermissionPageId",
                table: "PermissionRoleAssigment",
                newName: "PermissionNamespaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PermissionNamespaceId",
                table: "PermissionUserAssigment",
                newName: "PermissionPageId");

            migrationBuilder.RenameColumn(
                name: "PermissionNamespaceId",
                table: "PermissionRoleAssigment",
                newName: "PermissionPageId");
        }
    }
}
