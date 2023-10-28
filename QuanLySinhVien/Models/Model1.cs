using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLySinhVien
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<NguoiDung> NguoiDung { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TaiKhoan)
                .IsFixedLength();

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.Lop)
                .IsFixedLength();
        }
    }
}
