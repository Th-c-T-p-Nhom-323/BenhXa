namespace BenhXa.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUDANGKY")]
    public partial class PHIEUDANGKY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUDANGKY()
        {
            PHIEUKHAMs = new HashSet<PHIEUKHAM>();
        }

        [Key]
        public int MaDK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDK { get; set; }

        public int? MaBN { get; set; }

        public virtual BENHNHAN BENHNHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUKHAM> PHIEUKHAMs { get; set; }
        public PHIEUDANGKY ( DateTime ngaydk,int maBn)
        {
            this.NgayDK = ngaydk;
            this.MaBN = maBn;
        }
    }
}
