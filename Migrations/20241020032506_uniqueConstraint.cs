using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNETProj.Migrations
{
    /// <inheritdoc />
    public partial class uniqueConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Customers_NationalCode",
                table: "Customers",
                column: "NationalCode",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Customers_NationalCode",
                table: "Customers");
        }
    }
}
