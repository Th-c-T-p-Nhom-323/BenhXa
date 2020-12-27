namespace BenhXa.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BENHNHAN")]
    public partial class BENHNHAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BENHNHAN()
        {
            PHIEUDANGKies = new HashSet<PHIEUDANGKY>();
        }

        [Key]
        public int MaBN { get; set; }

        [StringLength(100)]
        public string TenBN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string CapBac { get; set; }

        [StringLength(50)]
        public string ChucVu { get; set; }

        [StringLength(50)]
        public string DonVi { get; set; }
        [StringLength(50)]
        public string GioiTinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUDANGKY> PHIEUDANGKies { get; set; }
        public BENHNHAN( string ten, DateTime ngaySinh, string capbac, string chucvu, string donvi,string gioitinh)
        {
            this.TenBN = ten;
            this.NgaySinh = ngaySinh;
            this.CapBac = capbac;
            this.ChucVu = chucvu;
            this.DonVi = donvi;
            this.GioiTinh = gioitinh;
        }
    }
}
