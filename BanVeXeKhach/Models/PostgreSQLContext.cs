using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BanVeXeKhach.Models
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options)
        {

        }
        public DbSet<Tinh> Tinh { get; set; }
        public DbSet<NhaXe> NhaXe { get; set; }
        public DbSet<Khach> Khach { get; set; }
        public DbSet<Nhom> Nhom { get; set; }

        public DbSet<VeNhom> VeNhom { get; set; }
        public DbSet<DanhSachTinhXeDiQua> DanhSachTinhXeDiQua { get; set; }
        public DbSet<DanhSachDatVe> DanhSachDatVe { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Khach>().HasKey(sc => sc.id);
            builder.Entity<VeNhom>().HasKey(sc => new { sc.idKhach, sc.idNhom });
            builder.Entity<DanhSachDatVe>().HasKey(sc => new { sc.idKhach, sc.idNhaXe });
            builder.Entity<DanhSachTinhXeDiQua>().HasKey(sc => new { sc.idNhaXe, sc.idTinh });

            builder.Entity<VeNhom>()
                .HasOne<Khach>(sc => sc.Khach)
                .WithMany()
                .HasForeignKey(sc => sc.idKhach);

            builder.Entity<VeNhom>()
                .HasOne<Nhom>(sc => sc.Nhom)
                .WithMany()
                .HasForeignKey(sc => sc.idNhom);


            builder.Entity<DanhSachDatVe>()
                .HasOne<Khach>(sc => sc.Khach)
                .WithMany()
                .HasForeignKey(sc => sc.idNhaXe);

            builder.Entity<DanhSachDatVe>()
                .HasOne<NhaXe>(sc => sc.NhaXe)
                .WithMany()
                .HasForeignKey(sc => sc.idNhaXe);


            builder.Entity<DanhSachTinhXeDiQua>()
                .HasOne<NhaXe>(sc => sc.NhaXe)
                .WithMany(s => s.DanhSachTinhXeDiQua)
                .HasForeignKey(sc => sc.idNhaXe);


            builder.Entity<DanhSachTinhXeDiQua>()
                .HasOne<Tinh>(sc => sc.Tinh)
                .WithMany(s => s.DanhSachXeDiQuaTinh)
                .HasForeignKey(sc => sc.idTinh);


            builder.Entity<Khach>()
                .HasOne<Tinh>(sc => sc.Tinh)
                .WithMany(sc => sc.DanhSachKhach)
                .HasForeignKey(sc => sc.idTinh);

            builder.Entity<VeNhom>().HasIndex(s => new { s.idKhach, s.idNhom }).IsUnique();
            builder.Entity<DanhSachDatVe>().HasIndex(s => new { s.idKhach, s.idNhaXe }).IsUnique();
            builder.Entity<DanhSachTinhXeDiQua>().HasIndex(s => new { s.idNhaXe, s.idTinh }).IsUnique();
            builder.Entity<Tinh>().HasIndex(s => s.tenTinh).IsUnique();
            builder.Entity<NhaXe>().HasIndex(s => s.bienSo).IsUnique();

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
