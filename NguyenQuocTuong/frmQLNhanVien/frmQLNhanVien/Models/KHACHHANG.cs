namespace frmQLNhanVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            HOADON = new HashSet<HOADON>();
            PHIEUTHUETHIETBI = new HashSet<PHIEUTHUETHIETBI>();
        }

        [Key]
        [StringLength(10)]
        public string MAKH { get; set; }

        [StringLength(35)]
        public string TENKH { get; set; }

        [Required]
        [StringLength(100)]
        public string DIACHI_KH { get; set; }

        [Required]
        [StringLength(15)]
        public string DIENTHOAI_KH { get; set; }

        [StringLength(50)]
        public string EMAIL_KH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUETHIETBI> PHIEUTHUETHIETBI { get; set; }
    }
}
