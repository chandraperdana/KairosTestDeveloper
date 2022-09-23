using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoalA.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MS_Barang",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nama_Barang = table.Column<string>(type: "varchar(200)", nullable: false),
                    Kode_Barang = table.Column<string>(type: "varchar(50)", nullable: false),
                    Jumlah_barang = table.Column<int>(type: "int", nullable: false),
                    Tanggal = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MS_Barang", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MS_Barang");
        }
    }
}
