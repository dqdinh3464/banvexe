using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BanVeXeKhach.Migrations
{
    public partial class BanVeXe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NhaXe",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    bienSo = table.Column<string>(type: "text", nullable: false),
                    tenNhaXe = table.Column<string>(type: "text", nullable: false),
                    soDienThoai = table.Column<string>(type: "text", nullable: false),
                    soGheNgoi = table.Column<int>(type: "integer", nullable: false),
                    soGheNam = table.Column<int>(type: "integer", nullable: false),
                    taiTrongMoiKhach = table.Column<int>(type: "integer", nullable: false),
                    thoiGianDi = table.Column<string>(type: "text", nullable: false)
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
                name: "DanhSachTinhXeDiQua",
                columns: table => new
                {
                    idNhaXe = table.Column<int>(type: "integer", nullable: false),
                    idTinh = table.Column<int>(type: "integer", nullable: false),
                    thuTu = table.Column<int>(type: "integer", nullable: false),
                    giaVe = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachTinhXeDiQua", x => new { x.idNhaXe, x.idTinh });
                    table.ForeignKey(
                        name: "FK_DanhSachTinhXeDiQua_NhaXe_idNhaXe",
                        column: x => x.idNhaXe,
                        principalTable: "NhaXe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachTinhXeDiQua_Tinh_idTinh",
                        column: x => x.idTinh,
                        principalTable: "Tinh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Khach",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    hoTen = table.Column<string>(type: "text", nullable: false),
                    soDienThoai = table.Column<string>(type: "text", nullable: false),
                    idTinh = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khach", x => x.id);
                    table.ForeignKey(
                        name: "FK_Khach_Tinh_idTinh",
                        column: x => x.idTinh,
                        principalTable: "Tinh",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachDatVe",
                columns: table => new
                {
                    idKhach = table.Column<int>(type: "integer", nullable: false),
                    idNhaXe = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachDatVe", x => new { x.idKhach, x.idNhaXe });
                    table.ForeignKey(
                        name: "FK_DanhSachDatVe_Khach_idNhaXe",
                        column: x => x.idNhaXe,
                        principalTable: "Khach",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhSachDatVe_NhaXe_idNhaXe",
                        column: x => x.idNhaXe,
                        principalTable: "NhaXe",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nhom",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    linkNhom = table.Column<string>(type: "text", nullable: true),
                    idTruongNhom = table.Column<int>(type: "integer", nullable: false),
                    TruongNhomid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nhom", x => x.id);
                    table.ForeignKey(
                        name: "FK_Nhom_Khach_TruongNhomid",
                        column: x => x.TruongNhomid,
                        principalTable: "Khach",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VeNhom",
                columns: table => new
                {
                    idKhach = table.Column<int>(type: "integer", nullable: false),
                    idNhom = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeNhom", x => new { x.idKhach, x.idNhom });
                    table.ForeignKey(
                        name: "FK_VeNhom_Khach_idKhach",
                        column: x => x.idKhach,
                        principalTable: "Khach",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VeNhom_Nhom_idNhom",
                        column: x => x.idNhom,
                        principalTable: "Nhom",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachDatVe_idKhach_idNhaXe",
                table: "DanhSachDatVe",
                columns: new[] { "idKhach", "idNhaXe" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachDatVe_idNhaXe",
                table: "DanhSachDatVe",
                column: "idNhaXe");

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachTinhXeDiQua_idNhaXe_idTinh",
                table: "DanhSachTinhXeDiQua",
                columns: new[] { "idNhaXe", "idTinh" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DanhSachTinhXeDiQua_idTinh",
                table: "DanhSachTinhXeDiQua",
                column: "idTinh");

            migrationBuilder.CreateIndex(
                name: "IX_Khach_idTinh",
                table: "Khach",
                column: "idTinh");

            migrationBuilder.CreateIndex(
                name: "IX_NhaXe_bienSo",
                table: "NhaXe",
                column: "bienSo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nhom_TruongNhomid",
                table: "Nhom",
                column: "TruongNhomid");

            migrationBuilder.CreateIndex(
                name: "IX_Tinh_tenTinh",
                table: "Tinh",
                column: "tenTinh",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VeNhom_idKhach_idNhom",
                table: "VeNhom",
                columns: new[] { "idKhach", "idNhom" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VeNhom_idNhom",
                table: "VeNhom",
                column: "idNhom");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DanhSachDatVe");

            migrationBuilder.DropTable(
                name: "DanhSachTinhXeDiQua");

            migrationBuilder.DropTable(
                name: "VeNhom");

            migrationBuilder.DropTable(
                name: "NhaXe");

            migrationBuilder.DropTable(
                name: "Nhom");

            migrationBuilder.DropTable(
                name: "Khach");

            migrationBuilder.DropTable(
                name: "Tinh");
        }
    }
}
