namespace DoAn_QuanLyBanNuoc.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NUOC")]
    public partial class NUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NUOC()
        {
            ORDER_TABLE = new HashSet<ORDER_TABLE>();
        }

        [Key]
        [StringLength(5)]
        public string IDNUOC { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNUOC { get; set; }

        public long GIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_TABLE> ORDER_TABLE { get; set; }
    }
}
