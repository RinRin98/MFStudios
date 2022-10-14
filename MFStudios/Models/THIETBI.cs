namespace MFStudios.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THIETBI")]
    public partial class THIETBI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THIETBI()
        {
            PHIEUTHUETHIETBIs = new HashSet<PHIEUTHUETHIETBI>();
        }

        [Key]
        [StringLength(10)]
        public string MATB { get; set; }

        [Required]
        [StringLength(35)]
        public string TENTB { get; set; }

        public double GIATRITB { get; set; }

        public double GIATHUE { get; set; }

        [Required]
        [StringLength(10)]
        public string MALOAI { get; set; }

        public virtual LOAITHIETBI LOAITHIETBI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUTHUETHIETBI> PHIEUTHUETHIETBIs { get; set; }
    }
}
