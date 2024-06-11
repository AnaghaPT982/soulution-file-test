using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AzureDotNetMVCapp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sunscreens",
                columns: table => new
                {
                    SunscreenId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SunscreenName = table.Column<string>(type: "text", nullable: false),
                    PARating = table.Column<string>(type: "text", nullable: false),
                    SPF = table.Column<string>(type: "text", nullable: false),
                    OxyBenzenoneFree = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sunscreens", x => x.SunscreenId);
                });

            migrationBuilder.InsertData(
                table: "Sunscreens",
                columns: new[] { "SunscreenId", "OxyBenzenoneFree", "PARating", "SPF", "SunscreenName" },
                values: new object[,]
                {
                    { 1, "NO", "PA ++++", "50", "Minimalist" },
                    { 2, "YES", "PA ++++", "60", "Derama Co" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sunscreens");
        }
    }
}
