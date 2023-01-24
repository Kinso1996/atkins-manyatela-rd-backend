using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticalTest.Migrations
{
    /// <inheritdoc />
    public partial class MathOperations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MathematicalOperations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SecondNumber = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MathOperation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MathResult = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MathematicalOperations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MathematicalOperations");
        }
    }
}
