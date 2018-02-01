using System.Windows;
using SembakoShop.model;

namespace MaterialShop.ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Karyawan _karyawan;


        public MainWindow(Karyawan karyawan)
        {
            InitializeComponent();
            frContent.Content = new uiPenjualan();
            _karyawan = karyawan;
        }

        

        private void btnKasir_Click(object sender, RoutedEventArgs e)
        {
            frContent.Content = new uiPenjualan();
        }

        private void btnKategri_Click(object sender, RoutedEventArgs e)
        {
            frContent.Content = new uiKategori();
        }

        private void btnBarang_Click(object sender, RoutedEventArgs e)
        {
            frContent.Content = new uiBarang();
        }

        private void btnSupplier_Click(object sender, RoutedEventArgs e)
        {
            frContent.Content = new uiSupplier();
        }

        private void btnBeli_Click(object sender, RoutedEventArgs e)
        {
            frContent.Content = new uiPembelian();
        }

        private void btnJual_Click(object sender, RoutedEventArgs e)
        {
            frContent.Content = new uiPenjualanReport();
        }

        private void btnKustomer_Click(object sender, RoutedEventArgs e)
        {
            frContent.Content = new uiMember();
        }

        private void btnKaryawan_Click(object sender, RoutedEventArgs e)
        {
            frContent.Content = new uiKaryawan();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (_karyawan.jabatan.Equals("admin"))
            {
               
            }
            else
            {
                btnBarang.Visibility = Visibility.Hidden;
                btnBeli.Visibility = Visibility.Hidden;
                btnKaryawan.Visibility = Visibility.Hidden;
                btnJual.Visibility = Visibility.Hidden;
                btnKategri.Visibility = Visibility.Hidden;
                btnSupplier.Visibility = Visibility.Hidden;
                btnKustomer.Visibility = Visibility.Hidden;
            }
        }
    }
}
