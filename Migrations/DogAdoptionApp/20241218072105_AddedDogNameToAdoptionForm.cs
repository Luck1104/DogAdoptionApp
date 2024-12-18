using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogAdoptionApp.Migrations.DogAdoptionApp
{
    /// <inheritdoc />
    public partial class AddedDogNameToAdoptionForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DogName",
                table: "AdoptionForm",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogName",
                table: "AdoptionForm");
        }
    }
}
