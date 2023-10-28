using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using static QuanLySinhVien.WindowInsert;

namespace QuanLySinhVien
{
    /// <summary>
    /// Interaction logic for WindowInsert.xaml
    /// </summary>
    public partial class WindowInsert : Window
    {
        Model1 db = new Model1();
        public delegate void DataChangedEventHnadler(object sender, EventArgs e);
        public event DataChangedEventHnadler DataChanged;
         private SinhVien selectedSinhVien;

        public WindowInsert()
        {
            InitializeComponent();
         
        }


        public WindowInsert(SinhVien sv)
        {
            InitializeComponent();
            selectedSinhVien = sv;
            if (selectedSinhVien != null)
            {
                // Điền dữ liệu vào các trường khi chức năng "Sửa" được kích hoạt
                ten.Text = selectedSinhVien.TenSV;
                lop1.Text = selectedSinhVien.Lop;
                gioitinh2.Text = selectedSinhVien.GioiTinh;
                DiemRL.Text = selectedSinhVien.DiemRenLuyen.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string TenSV = ten.Text;
                string Lop = lop1.Text;
                string GoiTinh = gioitinh2.Text;
                int DienRenLuyen = int.Parse(DiemRL.Text);

                if (selectedSinhVien == null)
                {
                    // Thực hiện chức năng "Thêm" khi không có SinhVien được chọn
                    var sinhVien = new SinhVien();
                    sinhVien.TenSV = TenSV;
                    sinhVien.Lop = Lop;
                    sinhVien.GioiTinh = GoiTinh;
                    sinhVien.DiemRenLuyen = DienRenLuyen;
                    db.SinhVien.Add(sinhVien);
                    db.SaveChanges();
                }
                else
                {
                    // Thực hiện chức năng "Sửa" khi có SinhVien được chọn
                    selectedSinhVien.TenSV = TenSV;
                    selectedSinhVien.Lop = Lop;
                    selectedSinhVien.GioiTinh = GoiTinh;
                    selectedSinhVien.DiemRenLuyen = DienRenLuyen;
                    db.SaveChanges();
                }

                MessageBox.Show("Lưu dữ liệu thành công!", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
                DataChangedEventHnadler handler = DataChanged;
                handler?.Invoke(this, new EventArgs());
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra. Vui lòng kiểm tra lại dữ liệu!", "Thông Báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}
