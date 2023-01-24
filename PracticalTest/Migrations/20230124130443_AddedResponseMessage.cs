using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticalTest.Migrations
{
    /// <inheritdoc />
    public partial class AddedResponseMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ResponseMessage",
                table: "MathematicalOperations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResponseMessage",
                table: "MathematicalOperations");
        }
    }
}
