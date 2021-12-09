using Microsoft.EntityFrameworkCore.Migrations;

namespace RestWork.Migrations
{
    public partial class NewModelFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Workers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MobileNum",
                table: "Workers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OfficeDesk",
                table: "Workers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OfficeNum",
                table: "Workers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Workers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Workers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "MobileNum",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "OfficeDesk",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "OfficeNum",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Workers");
        }
    }
}
