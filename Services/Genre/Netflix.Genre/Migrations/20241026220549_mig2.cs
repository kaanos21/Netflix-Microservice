using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Netflix.Genre.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreMappingId",
                table: "GenreMappings",
                newName: "GenreMappingsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreMappingsId",
                table: "GenreMappings",
                newName: "GenreMappingId");
        }
    }
}
