namespace BenhXa.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOSOBENHAN")]
    public partial class HOSOBENHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOSOBENHAN()
        {
            PHIEUKHAMs = new HashSet<PHIEUKHAM>();
        }

        [Key]
        public int MaBA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAM> PHIEUKHAMs { get; set; }
    }
}
