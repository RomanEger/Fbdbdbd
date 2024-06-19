using System;
using System.Collections.Generic;
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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для PageCart.xaml
    /// </summary>
    public partial class PageCart : Page
    {
        public PageCart()
        {
            InitializeComponent();
            MakerDGV.ItemsSource = Class1.connectbd.Cartridzhi.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Class1.connectbd.SaveChanges();
                MakerDGV.ItemsSource = Class1.connectbd.Cartridzhi.ToList();
                MessageBox.Show("Изменения успешно сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var prodDel = (MakerDGV.SelectedItem as Cartridzhi);
                Class1.connectbd.Cartridzhi.Remove(prodDel);
                Class1.connectbd.SaveChanges();
                MakerDGV.ItemsSource = Class1.connectbd.Cartridzhi.ToList();
                MessageBox.Show("Производитель удален");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Class1.frmobj.GoBack();
        }
    }
}
