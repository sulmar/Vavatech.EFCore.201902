using Microsoft.EntityFrameworkCore.Migrations;

namespace Vavatech.EFCore.DbServices.Migrations
{
    public partial class AddSalaryToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "Customers",
                nullable: false,
                defaultValue: 0m);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Customers");

          
        }
    }
}
