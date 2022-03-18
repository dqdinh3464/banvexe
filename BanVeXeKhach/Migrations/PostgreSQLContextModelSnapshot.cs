﻿// <auto-generated />
using BanVeXeKhach.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BanVeXeKhach.Migrations
{
    [DbContext(typeof(PostgreSQLContext))]
    partial class PostgreSQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BanVeXeKhach.Models.DanhSachDatVe", b =>
                {
                    b.Property<int>("idKhach")
                        .HasColumnType("integer");

                    b.Property<int>("idNhaXe")
                        .HasColumnType("integer");

                    b.Property<string>("maNhom")
                        .HasColumnType("text");

                    b.HasKey("idKhach", "idNhaXe");

                    b.HasIndex("idNhaXe");

                    b.HasIndex("idKhach", "idNhaXe")
                        .IsUnique();

                    b.ToTable("DanhSachDatVe");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.DanhSachTinhXeDiQua", b =>
                {
                    b.Property<int>("idNhaXe")
                        .HasColumnType("integer");

                    b.Property<int>("idTinh")
                        .HasColumnType("integer");

                    b.Property<int>("giaVe")
                        .HasColumnType("integer");

                    b.Property<int>("thuTu")
                        .HasColumnType("integer");

                    b.HasKey("idNhaXe", "idTinh");

                    b.HasIndex("idTinh");

                    b.HasIndex("idNhaXe", "idTinh")
                        .IsUnique();

                    b.ToTable("DanhSachTinhXeDiQua");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.Khach", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("hoTen")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("idTinh")
                        .HasColumnType("integer");

                    b.Property<string>("maNhom")
                        .HasColumnType("text");

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("truongNhom")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.HasIndex("idTinh");

                    b.ToTable("Khach");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.NhaXe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("bienSo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("soDienThoai")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("soGheNam")
                        .HasColumnType("integer");

                    b.Property<int>("soGheNgoi")
                        .HasColumnType("integer");

                    b.Property<int>("taiTrongMoiKhach")
                        .HasColumnType("integer");

                    b.Property<string>("tenNhaXe")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("thoiGianDi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("bienSo")
                        .IsUnique();

                    b.ToTable("NhaXe");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.Tinh", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("tenTinh")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("id");

                    b.HasIndex("tenTinh")
                        .IsUnique();

                    b.ToTable("Tinh");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.DanhSachDatVe", b =>
                {
                    b.HasOne("BanVeXeKhach.Models.Khach", "Khach")
                        .WithMany()
                        .HasForeignKey("idKhach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BanVeXeKhach.Models.NhaXe", "NhaXe")
                        .WithMany("DanhSachDatVe")
                        .HasForeignKey("idNhaXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khach");

                    b.Navigation("NhaXe");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.DanhSachTinhXeDiQua", b =>
                {
                    b.HasOne("BanVeXeKhach.Models.NhaXe", "NhaXe")
                        .WithMany("DanhSachTinhXeDiQua")
                        .HasForeignKey("idNhaXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BanVeXeKhach.Models.Tinh", "Tinh")
                        .WithMany("DanhSachXeDiQuaTinh")
                        .HasForeignKey("idTinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaXe");

                    b.Navigation("Tinh");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.Khach", b =>
                {
                    b.HasOne("BanVeXeKhach.Models.Tinh", "Tinh")
                        .WithMany()
                        .HasForeignKey("idTinh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tinh");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.NhaXe", b =>
                {
                    b.Navigation("DanhSachDatVe");

                    b.Navigation("DanhSachTinhXeDiQua");
                });

            modelBuilder.Entity("BanVeXeKhach.Models.Tinh", b =>
                {
                    b.Navigation("DanhSachXeDiQuaTinh");
                });
#pragma warning restore 612, 618
        }
    }
}
