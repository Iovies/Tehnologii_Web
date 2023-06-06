using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SMCS.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddHrefToContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Path",
                table: "ContentTrackers",
                newName: "LacalPath");

            migrationBuilder.AddColumn<string>(
                name: "Href",
                table: "ContentTrackers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Href",
                table: "ContentTrackers");

            migrationBuilder.RenameColumn(
                name: "LacalPath",
                table: "ContentTrackers",
                newName: "Path");
        }
    }
}
