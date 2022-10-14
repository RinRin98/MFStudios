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

        [StringLength(10)]
        public string MAKH { get; set; }

        [StringLength(10)]
        public string MAPTHUE { get; set; }

        public DateTime? NGAYLAP { get; set; }

        public double TONGTIEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual PHIEUTHUETHIETBI PHIEUTHUETHIETBI { get; set; }
    }
}
