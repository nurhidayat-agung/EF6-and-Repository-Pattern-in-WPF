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
using MaterialShop.util;
using SembakoShop.model;

namespace MaterialShop.ui
{
    /// <summary>
    /// Interaction logic for uiMember.xaml
    /// </summary>
    public partial class uiMember : Page
    {
        public uiMember()
        {
            InitializeComponent();
            loadCustomer();
        }

        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                Customer customer = new Customer();
                customer.namaCustomer = tbxNamaCustomer.Text;
                uow.Customer.Add(customer);
                uow.Complete();
                loadCustomer();
            }
        }

        private void loadCustomer()
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                List<Customer> list = new List<Customer>(uow.Customer.GetAll());
                dgCustomer.ItemsSource = list;

            }

        }
    }
}
