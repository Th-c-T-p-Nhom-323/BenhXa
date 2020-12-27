namespace BenhXa.DAO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETTOATHUOC")]
    public partial class CHITIETTOATHUOC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThuoc { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTT { get; set; }

        public int? SoLuong { get; set; }

        public string HuongDan { get; set; }

        public virtual THUOC THUOC { get; set; }

        public virtual TOATHUOC TOATHUOC { get; set; }
    }
}
