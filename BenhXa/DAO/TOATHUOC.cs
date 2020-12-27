namespace BenhXa.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOATHUOC")]
    public partial class TOATHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TOATHUOC()
        {
            CHITIETTOATHUOCs = new HashSet<CHITIETTOATHUOC>();
        }

        [Key]
        public int MaTT { get; set; }

        public int? MaPK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [StringLength(50)]
        public string SoTheBHYT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTOATHUOC> CHITIETTOATHUOCs { get; set; }

        public virtual PHIEUKHAM PHIEUKHAM { get; set; }
    }
}
