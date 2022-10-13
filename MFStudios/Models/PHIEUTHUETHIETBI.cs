namespace MFStudios.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHUETHIETBI")]
    public partial class PHIEUTHUETHIETBI
    {
        [Key]
        [StringLength(10)]
        public string MAPTHUE { get; set; }

        public int SOLUONG { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYTHUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYHENTRA { get; set; }

        public double TIENCOC { get; set; }

        [Required]
        [StringLength(10)]
        public string MAKH { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        [Required]
        [StringLength(10)]
        public string MATB { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual THIETBI THIETBI { get; set; }
    }
}
