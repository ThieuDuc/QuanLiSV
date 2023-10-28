namespace QuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDung")]
    public partial class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        [Required]
        [StringLength(30)]
        public string TaiKhoan { get; set; }

        [Required]
        [StringLength(30)]
        public string MatKhau { get; set; }

        [Required]
        [StringLength(50)]
        public string VaiTro { get; set; }
    }
}
