using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment4.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablePeminjaman : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxBuku",
                table: "Peminjamans");

            migrationBuilder.RenameColumn(
                name: "Tanggal",
                table: "Peminjamans",
                newName: "TanggalPinjam");

            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalKembali",
                table: "Peminjamans",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TanggalKembali",
                table: "Peminjamans");

            migrationBuilder.RenameColumn(
                name: "TanggalPinjam",
                table: "Peminjamans",
                newName: "Tanggal");

            migrationBuilder.AddColumn<int>(
                name: "MaxBuku",
                table: "Peminjamans",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
