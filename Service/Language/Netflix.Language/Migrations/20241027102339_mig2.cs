using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix.Language.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubtitleId",
                table: "Subtitles",
                newName: "SubtitlesId");

            migrationBuilder.AlterColumn<string>(
                name: "SubtitleFileUrl",
                table: "Subtitles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubtitlesId",
                table: "Subtitles",
                newName: "SubtitleId");

            migrationBuilder.AlterColumn<int>(
                name: "SubtitleFileUrl",
                table: "Subtitles",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
