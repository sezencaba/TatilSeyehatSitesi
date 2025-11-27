using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcSeyehatSitesi_20._10._2025.Migrations
{
    /// <inheritdoc />
    public partial class IletisimOkunduMuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OkunduMu",
                table: "iletisims",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OkunduMu",
                table: "iletisims");
        }
    }
}


