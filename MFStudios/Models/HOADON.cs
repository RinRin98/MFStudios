namespace MFStudios.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        [StringLength(10)]
        public string MAHD { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYTHUE { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAYHENTRA { get; set; }

        [Required]
        [StringLength(1000)]
        public string THONGTINDONHANG { get; set; }

        [Required]
        [StringLength(10)]
        public string MAKH { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        [StringLength(10)]
        public string MATB { get; set; }

        public double TONGTIEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        public virtual THIETBI THIETBI { get; set; }
    }
}
