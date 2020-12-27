namespace BenhXa.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUKHAM")]
    public partial class PHIEUKHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUKHAM()
        {
            TOATHUOCs = new HashSet<TOATHUOC>();
        }

        [Key]
        public int MaPK { get; set; }

        public int? MaBA { get; set; }

        public int? MaDK { get; set; }

        public int? MaBS { get; set; }

        public string TrieuChung { get; set; }

        public string ChuanDoan { get; set; }

        public bool? TaiKham { get; set; }

        public string HuongDieuTri { get; set; }

        public virtual BACSI BACSI { get; set; }

        public virtual HOSOBENHAN HOSOBENHAN { get; set; }

        public virtual PHIEUDANGKY PHIEUDANGKY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOATHUOC> TOATHUOCs { get; set; }
    }
}
