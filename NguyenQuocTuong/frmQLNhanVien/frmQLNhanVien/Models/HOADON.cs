namespace frmQLNhanVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            CT_HOADON = new HashSet<CT_HOADON>();
        }

        [Key]
        [StringLength(10)]
        public string MAHD { get; set; }

        [StringLength(10)]
        public string MAKH { get; set; }

        [StringLength(10)]
        public string MATB { get; set; }

        public DateTime? NGAYLAP { get; set; }

        public double TONGTIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOADON> CT_HOADON { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual THIETBI THIETBI { get; set; }
    }
}
