using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoalA.Migrations
{
    public partial class changeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Jumlah_barang",
                table: "MS_Barang",
                newName: "Jumlah_Barang");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Jumlah_Barang",
                table: "MS_Barang",
                newName: "Jumlah_barang");
        }
    }
}
