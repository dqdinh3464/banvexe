using Microsoft.EntityFrameworkCore.Migrations;

namespace BanVeXeKhach.Migrations
{
    public partial class BanVeXeKhach1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "maNhom",
                table: "DanhSachDatVe",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "maNhom",
                table: "DanhSachDatVe");
        }
    }
}
