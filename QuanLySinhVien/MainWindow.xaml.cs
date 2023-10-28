using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLySinhVien
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Model1 db = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            getData();
            
        }
        public void getData()
        {
            datagridSV.ItemsSource = db.SinhVien.ToList();
        }

        private void Insert(object sender, RoutedEventArgs e)
        {
            WindowInsert insert = new WindowInsert();
            insert.DataChanged += Window_DataChanged;
            insert.Show();
        }
        private void Window_DataChanged(object sender, EventArgs e)
        {
            getData();
        }


        private void Button_delete(object sender, RoutedEventArgs e)
        {
            if (datagridSV.SelectedItem != null)
            {
                SinhVien selectedSinhVien = datagridSV.SelectedItem as SinhVien;
                db.SinhVien.Remove(selectedSinhVien);
                db.SaveChanges();
                getData();
            }
        }
        private void Sua_Click(object sender, RoutedEventArgs e)
        {
            if (datagridSV.SelectedItem != null)
            {
                SinhVien selectedSinhVien = datagridSV.SelectedItem as SinhVien;
                WindowInsert edit = new WindowInsert(selectedSinhVien);
                edit.ShowDialog();
                getData();
            }
        }

        private void TimKiem_Click(object sender, RoutedEventArgs e)
        {
            string ten = timten.Text;
            string gioiTinh = Goitinh.Text;

            var query = from sv in db.SinhVien
                        where sv.TenSV.Contains(ten) && sv.GioiTinh == gioiTinh
                        select sv;

            datagridSV.ItemsSource = query.ToList();
        }

    }
}
