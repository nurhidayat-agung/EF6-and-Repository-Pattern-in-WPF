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
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using MaterialShop.util;
using SembakoShop.model;

namespace MaterialShop.ui
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
       

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void TbxNik_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !UtilsApp.IsTextAllowed(e.Text);
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                List<Karyawan> karyawans = uow.Karyawan.login(int.Parse(tbxNik.Text), tbxPass.Password);
                if (karyawans.Count > 0)
                {
                    MainWindow mainWindow = new MainWindow(karyawans[0]);
                    this.Hide();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("login gagal");
                }
            }

        }
    }
}
