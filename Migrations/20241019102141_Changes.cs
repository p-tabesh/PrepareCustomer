using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspNETProj.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Customers_CustomerId",
                table: "Phone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phone",
                table: "Phone");

            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "dbo",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "Phone",
                newName: "Phones");

            migrationBuilder.RenameIndex(
                name: "IX_Phone_CustomerId",
                table: "Phones",
                newName: "IX_Phones_CustomerId");

            migrationBuilder.AlterTable(
                name: "Customers",
                comment: "Customers Table",
                oldComment: "Customer Table");

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                table: "Customers",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Id Field")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Phones",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Customers_CustomerId",
                table: "Phones",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Customers_CustomerId",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customers",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Phones",
                newName: "Phone");

            migrationBuilder.RenameIndex(
                name: "IX_Phones_CustomerId",
                table: "Phone",
                newName: "IX_Phone_CustomerId");

            migrationBuilder.AlterTable(
                name: "Customers",
                schema: "dbo",
                comment: "Customer Table",
                oldComment: "Customers Table");

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                schema: "dbo",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                schema: "dbo",
                table: "Customers",
                type: "int",
                nullable: false,
                comment: "Id Field",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Phone",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phone",
                table: "Phone",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Customers_CustomerId",
                table: "Phone",
                column: "CustomerId",
                principalSchema: "dbo",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
