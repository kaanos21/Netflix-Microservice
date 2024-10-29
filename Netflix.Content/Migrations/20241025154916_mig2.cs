using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix.Content.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeasonNumber",
                table: "Episodes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SeasonNumber",
                table: "Episodes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
