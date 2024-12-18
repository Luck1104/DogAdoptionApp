using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogAdoptionApp.Migrations.DogAdoptionApp
{
    /// <inheritdoc />
    public partial class AddImageFieldAndExtraValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AdoptionStatus",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<string>(
                name: "DogImage",
                table: "Dog",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogImage",
                table: "Dog");

            migrationBuilder.AlterColumn<string>(
                name: "AdoptionStatus",
                table: "Dog",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
