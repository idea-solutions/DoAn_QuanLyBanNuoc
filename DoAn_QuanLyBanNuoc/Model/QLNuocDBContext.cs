using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAn_QuanLyBanNuoc.Model
{
    public partial class QLNuocDBContext : DbContext
    {
        public QLNuocDBContext()
            : base("name=QLNuocDBContext")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<BAN> BANs { get; set; }
        public virtual DbSet<NUOC> NUOCs { get; set; }
        public virtual DbSet<ORDER_TABLE> ORDER_TABLE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.ACCOUNTID)
                .IsFixedLength();

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PASSWORD)
                .IsFixedLength();

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PHONENUM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .HasMany(e => e.ORDER_TABLE)
                .WithRequired(e => e.ACCOUNT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BAN>()
                .Property(e => e.IDBAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BAN>()
                .HasMany(e => e.ORDER_TABLE)
                .WithRequired(e => e.BAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NUOC>()
                .Property(e => e.IDNUOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NUOC>()
                .HasMany(e => e.ORDER_TABLE)
                .WithRequired(e => e.NUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ORDER_TABLE>()
                .Property(e => e.IDBAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_TABLE>()
                .Property(e => e.ACCOUNTID)
                .IsFixedLength();

            modelBuilder.Entity<ORDER_TABLE>()
                .Property(e => e.IDNUOC)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
