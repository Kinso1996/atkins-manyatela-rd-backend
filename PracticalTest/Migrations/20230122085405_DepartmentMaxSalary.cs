using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticalTest.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentMaxSalary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MaxSalary",
                table: "Departments",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxSalary",
                table: "Departments");
        }
    }
}
