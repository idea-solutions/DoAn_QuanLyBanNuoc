namespace DoAn_QuanLyBanNuoc.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BAN")]
    public partial class BAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAN()
        {
            ORDER_TABLE = new HashSet<ORDER_TABLE>();
        }

        [Key]
        [StringLength(6)]
        public string IDBAN { get; set; }

        public bool? DACHON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_TABLE> ORDER_TABLE { get; set; }
    }
}
