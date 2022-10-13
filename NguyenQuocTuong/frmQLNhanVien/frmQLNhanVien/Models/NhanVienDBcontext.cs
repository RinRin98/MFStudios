using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace frmQLNhanVien.Models
{
    public partial class NhanVienDBcontext : DbContext
    {
        public NhanVienDBcontext()
            : base("name=NhanVienDBcontext")
        {
        }

        public virtual DbSet<CT_HOADON> CT_HOADON { get; set; }
        public virtual DbSet<CHUCVU> CHUCVU { get; set; }
        public virtual DbSet<HOADON> HOADON { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }
        public virtual DbSet<LOAITHIETBI> LOAITHIETBI { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHIEUTHUETHIETBI> PHIEUTHUETHIETBI { get; set; }
        public virtual DbSet<THIETBI> THIETBI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.SOHD)
                .IsUnicode(false);

            modelBuilder.Entity<CT_HOADON>()
                .Property(e => e.MATB)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .Property(e => e.MACV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHD)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MATB)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.HOADON)
                .HasForeignKey(e => e.SOHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.DIENTHOAI_KH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.EMAIL_KH)
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.HOADON)
                .WithOptional(e => e.KHACHHANG)
                .WillCascadeOnDelete();

            modelBuilder.Entity<KHACHHANG>()
                .HasMany(e => e.PHIEUTHUETHIETBI)
                .WithRequired(e => e.KHACHHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAITHIETBI>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<LOAITHIETBI>()
                .HasMany(e => e.THIETBI)
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
                .Property(e => e.EMAIL_NV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUTHUETHIETBI)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUTHUETHIETBI>()
                .Property(e => e.MAPTHUE)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUETHIETBI>()
                .Property(e => e.MAKH)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUETHIETBI>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUTHUETHIETBI>()
                .Property(e => e.MATB)
                .IsUnicode(false);

            modelBuilder.Entity<THIETBI>()
                .Property(e => e.MATB)
                .IsUnicode(false);

            modelBuilder.Entity<THIETBI>()
                .Property(e => e.MALOAI)
                .IsUnicode(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.CT_HOADON)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.HOADON)
                .WithOptional(e => e.THIETBI)
                .WillCascadeOnDelete();

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.PHIEUTHUETHIETBI)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);
        }
    }
}
