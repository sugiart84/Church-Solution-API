using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Church_Solution_API.Migrations
{
    /// <inheritdoc />
    public partial class POUKDB_v09 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionAction",
                keyColumn: "PermissionActionId",
                keyValue: "afa1b4f4-7887-4098-b4be-9034bdc4981f");

            migrationBuilder.DeleteData(
                table: "PermissionAction",
                keyColumn: "PermissionActionId",
                keyValue: "f13ecb9c-5a4e-4260-bc9f-1d9d2a428f7c");

            migrationBuilder.DeleteData(
                table: "PermissionNamespace",
                keyColumn: "PermissionNamespaceId",
                keyValue: "f0f04aac-312e-4575-b2c4-3054007fd6fa");

            migrationBuilder.DeleteData(
                table: "PermissionRoleAssigment",
                keyColumn: "PermissionRoleAssigmentId",
                keyValue: "75c5c66b-7a09-4e3d-8a81-eb6ec55c9195");

            migrationBuilder.DeleteData(
                table: "PermissionRoleAssigment",
                keyColumn: "PermissionRoleAssigmentId",
                keyValue: "a4eaa2b2-b559-4f91-8403-d7085b0aa0c8");

            migrationBuilder.DeleteData(
                table: "UserRolesAssigment",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73dfbc8d-beaa-481f-adc6-a91ea3576cd4", "c6807f37-a17b-4d8c-8949-7f87633270b7" });

            migrationBuilder.DeleteData(
                table: "RolesAssigment",
                keyColumn: "Id",
                keyValue: "73dfbc8d-beaa-481f-adc6-a91ea3576cd4");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c6807f37-a17b-4d8c-8949-7f87633270b7");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "afa1b4f4-7887-4098-b4be-9034bdc4981f", "c6807f37-a17b-4d8c-8949-7f87633270b7", new DateTime(2023, 12, 27, 19, 17, 26, 450, DateTimeKind.Local).AddTicks(3818), "create", true },
                    { "f13ecb9c-5a4e-4260-bc9f-1d9d2a428f7c", "c6807f37-a17b-4d8c-8949-7f87633270b7", new DateTime(2023, 12, 27, 19, 17, 26, 450, DateTimeKind.Local).AddTicks(3807), "read", true }
                });

            migrationBuilder.InsertData(
                table: "PermissionNamespace",
                columns: new[] { "PermissionNamespaceId", "CreatedBy", "CreatedDate", "Name", "isActive" },
                values: new object[] { "f0f04aac-312e-4575-b2c4-3054007fd6fa", "c6807f37-a17b-4d8c-8949-7f87633270b7", new DateTime(2023, 12, 27, 19, 17, 26, 450, DateTimeKind.Local).AddTicks(3778), "PermissionNamespace", true });

            migrationBuilder.InsertData(
                table: "PermissionRoleAssigment",
                columns: new[] { "PermissionRoleAssigmentId", "PermissionActionId", "PermissionNamespaceId", "RoleId" },
                values: new object[,]
                {
                    { "75c5c66b-7a09-4e3d-8a81-eb6ec55c9195", "afa1b4f4-7887-4098-b4be-9034bdc4981f", "f0f04aac-312e-4575-b2c4-3054007fd6fa", "73dfbc8d-beaa-481f-adc6-a91ea3576cd4" },
                    { "a4eaa2b2-b559-4f91-8403-d7085b0aa0c8", "f13ecb9c-5a4e-4260-bc9f-1d9d2a428f7c", "f0f04aac-312e-4575-b2c4-3054007fd6fa", "73dfbc8d-beaa-481f-adc6-a91ea3576cd4" }
                });

            migrationBuilder.InsertData(
                table: "RolesAssigment",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73dfbc8d-beaa-481f-adc6-a91ea3576cd4", null, "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "AccountActive", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6807f37-a17b-4d8c-8949-7f87633270b7", 0, false, "920d8387-7e86-46ae-b4af-87f5b02ecd40", null, null, false, null, false, null, null, "ADMIN@MAIL.COM", "AQAAAAIAAYagAAAAEPXKiWZQ2UBcwiOVZFZvBzY14E8Y60DTi5qZoxJ0ig8MNxEGcwiucZhOuMCspT8QyA==", null, false, null, null, "c9eb5be3-b927-40a6-aa56-9d93d234faad", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "UserRolesAssigment",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "73dfbc8d-beaa-481f-adc6-a91ea3576cd4", "c6807f37-a17b-4d8c-8949-7f87633270b7" });
        }
    }
}
