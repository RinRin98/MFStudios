using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MFStudios.Models
{
    public partial class DBMFStudios : DbContext
    {
        public DBMFStudios()
            : base("name=DBMFStudios")
        {
        }

        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LOAITHIETBI> LOAITHIETBIs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MATB)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAITHIETBI>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<LOAITHIETBI>()
                .HasMany(e => e.THIETBIs)
                .WithRequired(e => e.LOAITHIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.PASS)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .Property(e => e.MATB)
                .IsUnicode(false);

            modelBuilder.Entity<THIETBI>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);
        }
    }
}
