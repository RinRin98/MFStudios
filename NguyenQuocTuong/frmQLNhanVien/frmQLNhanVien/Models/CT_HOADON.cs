namespace frmQLNhanVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string SOHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MATB { get; set; }

        public DateTime NGAYTHUE { get; set; }

        public DateTime NGAYTRA { get; set; }

        public double GIATHUE { get; set; }

        public int SOLUONG { get; set; }

        public virtual THIETBI THIETBI { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
