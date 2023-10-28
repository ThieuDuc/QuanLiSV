namespace QuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        public int MaSV { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSV { get; set; }

        [Required]
        [StringLength(10)]
        public string Lop { get; set; }

        [Required]
        [StringLength(20)]
        public string GioiTinh { get; set; }

        public double DiemRenLuyen { get; set; }
    }
}
