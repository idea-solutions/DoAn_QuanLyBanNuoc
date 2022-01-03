namespace DoAn_QuanLyBanNuoc.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORDER_TABLE
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string IDBAN { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDORDER { get; set; }

        [Required]
        [StringLength(10)]
        public string ACCOUNTID { get; set; }

        [Required]
        [StringLength(5)]
        public string IDNUOC { get; set; }

        public int SOLUONGNUOC { get; set; }

        public long TONGTIEN { get; set; }

        public DateTime? THOIGIAN { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual BAN BAN { get; set; }

        public virtual NUOC NUOC { get; set; }
    }
}
