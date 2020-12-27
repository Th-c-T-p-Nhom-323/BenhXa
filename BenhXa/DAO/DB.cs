namespace BenhXa.DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<BACSI> BACSIs { get; set; }
        public virtual DbSet<BENHNHAN> BENHNHANs { get; set; }
        public virtual DbSet<CHITIETTOATHUOC> CHITIETTOATHUOCs { get; set; }
        public virtual DbSet<HOSOBENHAN> HOSOBENHANs { get; set; }
        public virtual DbSet<PHIEUDANGKY> PHIEUDANGKies { get; set; }
        public virtual DbSet<PHIEUKHAM> PHIEUKHAMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THUOC> THUOCs { get; set; }
        public virtual DbSet<TOATHUOC> TOATHUOCs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<THUOC>()
                .HasMany(e => e.CHITIETTOATHUOCs)
                .WithRequired(e => e.THUOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TOATHUOC>()
                .Property(e => e.SoTheBHYT)
                .IsUnicode(false);

            modelBuilder.Entity<TOATHUOC>()
                .HasMany(e => e.CHITIETTOATHUOCs)
                .WithRequired(e => e.TOATHUOC)
                .WillCascadeOnDelete(false);
        }
    }
}
