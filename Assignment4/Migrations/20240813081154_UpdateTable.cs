using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment4.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeminjamanId",
                table: "Books",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PeminjamanId",
                table: "Books",
                column: "PeminjamanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Peminjamans_PeminjamanId",
                table: "Books",
                column: "PeminjamanId",
                principalTable: "Peminjamans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Peminjamans_PeminjamanId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PeminjamanId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PeminjamanId",
                table: "Books");
        }
    }
}
