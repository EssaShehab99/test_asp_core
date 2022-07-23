using Microsoft.EntityFrameworkCore.Migrations;

namespace test_app.Migrations
{
    public partial class initial6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Phones");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Phones",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
