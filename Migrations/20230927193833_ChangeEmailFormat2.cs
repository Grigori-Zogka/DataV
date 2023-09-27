using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataV.Migrations
{
    public partial class ChangeEmailFormat2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");
        }
    }
}
