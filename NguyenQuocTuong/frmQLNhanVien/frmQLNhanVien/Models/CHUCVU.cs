namespace frmQLNhanVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHUCVU")]
    public partial class CHUCVU
    {
        [Key]
        [StringLength(10)]
        public string MACV { get; set; }

        [StringLength(50)]
        public string TENCV { get; set; }
    }
}
