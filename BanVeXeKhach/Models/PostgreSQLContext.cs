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
        public DbSet<DanhSachTinhXeDiQua> DanhSachTinhXeDiQua { get; set; }
        public DbSet<DanhSachDatVe> DanhSachDatVe { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DanhSachTinhXeDiQua>().HasIndex(s => new { s.idNhaXe, s.idTinh, s.thuTu }).IsUnique();

            //configuration relationship
            builder.Entity<DanhSachTinhXeDiQua>()
                .HasOne(s => s.NhaXe)
                .WithMany(s => s.DanhSachTinhXeDiQua)
                .HasForeignKey(s => s.idNhaXe)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<DanhSachTinhXeDiQua>()
                .HasOne(s => s.Tinh)
                .WithMany(s => s.DanhSachTinhXeDiQua)
                .HasForeignKey(s => s.idTinh)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Tinh>().HasIndex(s => s.tenTinh).IsUnique();
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
