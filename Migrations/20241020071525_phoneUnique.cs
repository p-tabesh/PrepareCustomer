using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNETProj.Migrations
{
    /// <inheritdoc />
    public partial class phoneUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Phones_Value",
                table: "Phones",
                column: "Value",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Phones_Value",
                table: "Phones");
        }
    }
}
