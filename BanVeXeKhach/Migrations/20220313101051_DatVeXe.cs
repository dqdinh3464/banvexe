using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BanVeXeKhach.Migrations
{
    public partial class DatVeXe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khach",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    hoTen = table.Column<string>(type: "text", nullable: true),
                    soDienThoai = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khach", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "NhaXe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bienSo = table.Column<string>(type: "text", nullable: true),
                    tenNhaXe = table.Column<string>(type: "text", nullable: true),
                    soDienThoai = table.Column<string>(type: "text", nullable: true),
                    soGheNgoi = table.Column<int>(type: "integer", nullable: false),
                    soGheNam = table.Column<int>(type: "integer", nullable: false),
                    taiTrongMoiKhach = table.Column<int>(type: "integer", nullable: false),
                    thoiGianDi = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXe", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tinh",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tenTinh = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tinh", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachDatVe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idKhach = table.Column<int>(type: "integer", nullable: false),
                    idNhaXe = table.Column<int>(type: "integer", nullable: false),
                    idTinh = table.Column<int>(type: "integer", nullable: false),
                    Khachid = table.Column<int>(type: "integer", nullable: true),
                    NhaXeid = table.Column<int>(type: "integer", nullable: true),
                    Tinhid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachDatVe", x => x.id);
                    table.ForeignKey(
                        name: "FK_DanhSachDatVe_Khach_Khachid",
                        column: x => x.Khachid,
                        principalTable: "Khach",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanhSachDatVe_NhaXe_NhaXeid",
                        column: x => x.NhaXeid,
                        principalTable: "NhaXe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanhSachDatVe_Tinh_Tinhid",
                        column: x => x.Tinhid,
                        principalTable: "Tinh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachTinhXeDiQua",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idNhaXe = table.Column<int>(type: "integer", nullable: false),
                    idTinh = table.Column<int>(type: "integer", nullable: false),
                    thuTu = table.Column<int>(type: "integer", nullable: false),
                    giaVe = table.Column<int>(type: "integer", nullable: false),
                    NhaXeid = table.Column<int>(type: "integer", nullable: true),
                    Tinhid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachTinhXeDiQua", x => x.id);
                    table.ForeignKey(
                        name: "FK_DanhSachTinhXeDiQua_NhaXe_NhaXeid",
                        column: x => x.NhaXeid,
                        principalTable: "NhaXe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DanhSachTinhXeDiQua_Tinh_Tinhid",
                        column: x => x.Tinhid,
                        principalTable: "Tinh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachDatVe_Khachid",
                table: "DanhSachDatVe",
                column: "Khachid");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachDatVe_NhaXeid",
                table: "DanhSachDatVe",
                column: "NhaXeid");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachDatVe_Tinhid",
                table: "DanhSachDatVe",
                column: "Tinhid");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachTinhXeDiQua_NhaXeid",
                table: "DanhSachTinhXeDiQua",
                column: "NhaXeid");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachTinhXeDiQua_Tinhid",
                table: "DanhSachTinhXeDiQua",
                column: "Tinhid");

            migrationBuilder.CreateIndex(
                name: "IX_Tinh_tenTinh",
                table: "Tinh",
                column: "tenTinh",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhSachDatVe");

            migrationBuilder.DropTable(
                name: "DanhSachTinhXeDiQua");

            migrationBuilder.DropTable(
                name: "Khach");

            migrationBuilder.DropTable(
                name: "NhaXe");

            migrationBuilder.DropTable(
                name: "Tinh");
        }
    }
}
