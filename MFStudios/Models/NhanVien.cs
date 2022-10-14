namespace MFStudios.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [Required]
        [StringLength(50)]
        public string PASS { get; set; }

        [Required]
        [StringLength(35)]
        public string HOTEN { get; set; }

        public bool? GIOITINH { get; set; }

        [Required]
        [StringLength(15)]
        public string SDT { get; set; }

        [Required]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(10)]
        public string MACV { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
