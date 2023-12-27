using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Church_Solution_API.Migrations
{
    /// <inheritdoc />
    public partial class POUKDB_v10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionAction",
                keyColumn: "PermissionActionId",
                keyValue: "2735282e-cdc4-4293-883c-4294880f765b");

            migrationBuilder.DeleteData(
                table: "PermissionAction",
                keyColumn: "PermissionActionId",
                keyValue: "7403cd3d-2093-43ad-b078-e427941d7d1a");

            migrationBuilder.DeleteData(
                table: "PermissionNamespace",
                keyColumn: "PermissionNamespaceId",
                keyValue: "aef6b819-42c4-450c-adbb-da6d496d9c76");

            migrationBuilder.DeleteData(
                table: "PermissionRoleAssigment",
                keyColumn: "PermissionRoleAssigmentId",
                keyValue: "47e02336-7c63-42ef-b780-5d84390395ad");

            migrationBuilder.DeleteData(
                table: "PermissionRoleAssigment",
                keyColumn: "PermissionRoleAssigmentId",
                keyValue: "cd6953a8-7559-4ac5-923d-734669e3d73b");

            migrationBuilder.DeleteData(
                table: "UserRolesAssigment",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b710f5f0-98a4-4453-8ac7-d9211e7810b6", "fba0b88a-0c47-415d-8cf3-6e5b7de578d5" });

            migrationBuilder.DeleteData(
                table: "RolesAssigment",
                keyColumn: "Id",
                keyValue: "b710f5f0-98a4-4453-8ac7-d9211e7810b6");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "fba0b88a-0c47-415d-8cf3-6e5b7de578d5");

            migrationBuilder.InsertData(
                table: "PermissionAction",
                columns: new[] { "PermissionActionId", "CreatedBy", "CreatedDate", "Name", "isActive" },
                values: new object[,]
                {
                    { "2bcaf127-b3e6-410e-ae4c-4a5afd461512", "9f2238e6-b722-4415-a8f0-234690e79fc0", new DateTime(2023, 12, 27, 19, 29, 28, 301, DateTimeKind.Local).AddTicks(3167), "read", true },
                    { "73f34412-eaa6-47e5-ac9c-7a8fe9698ab9", "9f2238e6-b722-4415-a8f0-234690e79fc0", new DateTime(2023, 12, 27, 19, 29, 28, 301, DateTimeKind.Local).AddTicks(3179), "create", true }
                });

            migrationBuilder.InsertData(
                table: "PermissionNamespace",
                columns: new[] { "PermissionNamespaceId", "CreatedBy", "CreatedDate", "Name", "isActive" },
                values: new object[] { "6cc28936-852a-4e75-8def-0165cf72a4fc", "9f2238e6-b722-4415-a8f0-234690e79fc0", new DateTime(2023, 12, 27, 19, 29, 28, 301, DateTimeKind.Local).AddTicks(3141), "PermissionNamespace", true });

            migrationBuilder.InsertData(
                table: "PermissionRoleAssigment",
                columns: new[] { "PermissionRoleAssigmentId", "PermissionActionId", "PermissionNamespaceId", "RoleId" },
                values: new object[,]
                {
                    { "07c67331-a4e1-40ae-a5e4-2f04a50003c9", "73f34412-eaa6-47e5-ac9c-7a8fe9698ab9", "6cc28936-852a-4e75-8def-0165cf72a4fc", "43fd2c28-62bc-4a80-8733-bb4448b9bd05" },
                    { "135cd52b-8d48-48cf-bc3a-e790dd188f36", "2bcaf127-b3e6-410e-ae4c-4a5afd461512", "6cc28936-852a-4e75-8def-0165cf72a4fc", "43fd2c28-62bc-4a80-8733-bb4448b9bd05" }
                });

            migrationBuilder.InsertData(
                table: "RolesAssigment",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43fd2c28-62bc-4a80-8733-bb4448b9bd05", null, "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AccountActive", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9f2238e6-b722-4415-a8f0-234690e79fc0", 0, false, "dd01e69a-e65d-4ce9-83ef-93188d3a0431", null, "admin@mail.com", true, "Super Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAECqlwJODv63H0KGuLbICshuaBCoTh9j0oqbd03eFGbHhaYz+oCamNnF1acCfq1xVlA==", null, false, null, null, "10ef872c-c2d8-42f6-b883-f46f9fc6f7dc", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "UserRolesAssigment",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "43fd2c28-62bc-4a80-8733-bb4448b9bd05", "9f2238e6-b722-4415-a8f0-234690e79fc0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionAction",
                keyColumn: "PermissionActionId",
                keyValue: "2bcaf127-b3e6-410e-ae4c-4a5afd461512");

            migrationBuilder.DeleteData(
                table: "PermissionAction",
                keyColumn: "PermissionActionId",
                keyValue: "73f34412-eaa6-47e5-ac9c-7a8fe9698ab9");

            migrationBuilder.DeleteData(
                table: "PermissionNamespace",
                keyColumn: "PermissionNamespaceId",
                keyValue: "6cc28936-852a-4e75-8def-0165cf72a4fc");

            migrationBuilder.DeleteData(
                table: "PermissionRoleAssigment",
                keyColumn: "PermissionRoleAssigmentId",
                keyValue: "07c67331-a4e1-40ae-a5e4-2f04a50003c9");

            migrationBuilder.DeleteData(
                table: "PermissionRoleAssigment",
                keyColumn: "PermissionRoleAssigmentId",
                keyValue: "135cd52b-8d48-48cf-bc3a-e790dd188f36");

            migrationBuilder.DeleteData(
                table: "UserRolesAssigment",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43fd2c28-62bc-4a80-8733-bb4448b9bd05", "9f2238e6-b722-4415-a8f0-234690e79fc0" });

            migrationBuilder.DeleteData(
                table: "RolesAssigment",
                keyColumn: "Id",
                keyValue: "43fd2c28-62bc-4a80-8733-bb4448b9bd05");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "9f2238e6-b722-4415-a8f0-234690e79fc0");

            migrationBuilder.InsertData(
                table: "PermissionAction",
                columns: new[] { "PermissionActionId", "CreatedBy", "CreatedDate", "Name", "isActive" },
                values: new object[,]
                {
                    { "2735282e-cdc4-4293-883c-4294880f765b", "fba0b88a-0c47-415d-8cf3-6e5b7de578d5", new DateTime(2023, 12, 27, 19, 24, 56, 576, DateTimeKind.Local).AddTicks(6419), "read", true },
                    { "7403cd3d-2093-43ad-b078-e427941d7d1a", "fba0b88a-0c47-415d-8cf3-6e5b7de578d5", new DateTime(2023, 12, 27, 19, 24, 56, 576, DateTimeKind.Local).AddTicks(6432), "create", true }
                });

            migrationBuilder.InsertData(
                table: "PermissionNamespace",
                columns: new[] { "PermissionNamespaceId", "CreatedBy", "CreatedDate", "Name", "isActive" },
                values: new object[] { "aef6b819-42c4-450c-adbb-da6d496d9c76", "fba0b88a-0c47-415d-8cf3-6e5b7de578d5", new DateTime(2023, 12, 27, 19, 24, 56, 576, DateTimeKind.Local).AddTicks(6395), "PermissionNamespace", true });

            migrationBuilder.InsertData(
                table: "PermissionRoleAssigment",
                columns: new[] { "PermissionRoleAssigmentId", "PermissionActionId", "PermissionNamespaceId", "RoleId" },
                values: new object[,]
                {
                    { "47e02336-7c63-42ef-b780-5d84390395ad", "7403cd3d-2093-43ad-b078-e427941d7d1a", "aef6b819-42c4-450c-adbb-da6d496d9c76", "b710f5f0-98a4-4453-8ac7-d9211e7810b6" },
                    { "cd6953a8-7559-4ac5-923d-734669e3d73b", "2735282e-cdc4-4293-883c-4294880f765b", "aef6b819-42c4-450c-adbb-da6d496d9c76", "b710f5f0-98a4-4453-8ac7-d9211e7810b6" }
                });

            migrationBuilder.InsertData(
                table: "RolesAssigment",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b710f5f0-98a4-4453-8ac7-d9211e7810b6", null, "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AccountActive", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fba0b88a-0c47-415d-8cf3-6e5b7de578d5", 0, false, "841d0e5c-bbe4-4c38-9dff-1a49fd83b228", null, "admin@mail.com", true, null, false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEGJVcDQk8BfohFtVO37EfPPWSTi2OP0V8b243QA3UmzF1N09pMtmeYs1i4A44UT6/A==", null, false, null, null, "f9dfde4b-7f76-4f70-afe0-3890592a65de", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "UserRolesAssigment",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b710f5f0-98a4-4453-8ac7-d9211e7810b6", "fba0b88a-0c47-415d-8cf3-6e5b7de578d5" });
        }
    }
}
