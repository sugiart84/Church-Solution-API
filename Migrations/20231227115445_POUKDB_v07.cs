using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church_Solution_API.Migrations
{
    /// <inheritdoc />
    public partial class POUKDB_v07 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MenuId",
                table: "MenuUserAssigment",
                newName: "MenuDesignId");

            migrationBuilder.CreateTable(
                name: "MenuDesign",
                columns: table => new
                {
                    MenuDesignId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MasterDesign = table.Column<bool>(type: "bit", nullable: false),
                    FromClone = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuDesign", x => x.MenuDesignId);
                });

            migrationBuilder.CreateTable(
                name: "MenuDesignDetail",
                columns: table => new
                {
                    MenuDesignDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuDesignId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MenuId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuDesignDetail", x => x.MenuDesignDetailId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuDesign");

            migrationBuilder.DropTable(
                name: "MenuDesignDetail");

            migrationBuilder.RenameColumn(
                name: "MenuDesignId",
                table: "MenuUserAssigment",
                newName: "MenuId");
        }
    }
}
