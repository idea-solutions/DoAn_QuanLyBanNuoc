namespace DoAn_QuanLyBanNuoc.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACCOUNT()
        {
            ORDER_TABLE = new HashSet<ORDER_TABLE>();
        }

        [StringLength(10)]
        public string ACCOUNTID { get; set; }

        [Required]
        [StringLength(10)]
        public string PASSWORD { get; set; }

        [Required]
        public string FULLNAME { get; set; }

        [Required]
        [StringLength(10)]
        public string PHONENUM { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_TABLE> ORDER_TABLE { get; set; }
    }
}
