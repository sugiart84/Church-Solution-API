using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Church_Solution_API.Migrations
{
    /// <inheritdoc />
    public partial class POUKDB_v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Family",
                columns: table => new
                {
                    FamilyCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JointDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Single = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Family", x => x.FamilyCode);
                });

            migrationBuilder.CreateTable(
                name: "FamilyMember",
                columns: table => new
                {
                    MemberCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FamilyCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaceofBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Etnic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PKBMember = table.Column<bool>(type: "bit", nullable: false),
                    PWMember = table.Column<bool>(type: "bit", nullable: false),
                    PemudaMember = table.Column<bool>(type: "bit", nullable: false),
                    RemajaMember = table.Column<bool>(type: "bit", nullable: false),
                    SekolahMingguMember = table.Column<bool>(type: "bit", nullable: false),
                    HasPassesAway = table.Column<bool>(type: "bit", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyMember", x => x.MemberCode);
                });

            migrationBuilder.CreateTable(
                name: "Majelis",
                columns: table => new
                {
                    MajelisCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajelisTypeCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MajelisPeriodCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majelis", x => x.MajelisCode);
                });

            migrationBuilder.CreateTable(
                name: "MajelisPeriod",
                columns: table => new
                {
                    MajelisPeriodCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajelisPeriodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartMonthPeriod = table.Column<int>(type: "int", nullable: false),
                    StartYearPeriod = table.Column<int>(type: "int", nullable: false),
                    EndMonthPeriod = table.Column<int>(type: "int", nullable: false),
                    EndYearPeriod = table.Column<int>(type: "int", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajelisPeriod", x => x.MajelisPeriodCode);
                });

            migrationBuilder.CreateTable(
                name: "MajelisType",
                columns: table => new
                {
                    MajelisTypeCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MajelisTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajelisType", x => x.MajelisTypeCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Family");

            migrationBuilder.DropTable(
                name: "FamilyMember");

            migrationBuilder.DropTable(
                name: "Majelis");

            migrationBuilder.DropTable(
                name: "MajelisPeriod");

            migrationBuilder.DropTable(
                name: "MajelisType");
        }
    }
}
