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
    /// Interaction logic for uiSupplier.xaml
    /// </summary>
    /// 
    public partial class uiSupplier : Page
    {
        List<Supplier> suppliers = new List<Supplier>();
        Supplier supplier = new Supplier();
        public uiSupplier()
        {
            InitializeComponent();
            loadDataSupplier();
        }

        private void btnTambah_Click(object sender, RoutedEventArgs e)
        {
            using (var unityOfWork = new UnitOfWork(new SembakoContext()))
            {
                Supplier supplier = new Supplier();
                supplier.supplierName = tbxSupplier.Text;
                unityOfWork.Supplier.Add(supplier);
                unityOfWork.Complete();
                loadDataSupplier();
            }
        }

        private void loadDataSupplier()
        {
            using (var unityOfWork = new UnitOfWork(new SembakoContext()))
            {
                suppliers  = new List<Supplier>();
                suppliers = new List<Supplier>(unityOfWork.Supplier.FindEntities(supplier1 => supplier1.isDel == false));
                dgSupplier.ItemsSource = suppliers;
            }
        }

        private void DgSupplier_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dgSupplier.SelectedIndex >= 0 && dgSupplier.Items.Count >= dgSupplier.SelectedIndex)
            {
                supplier = suppliers[dgSupplier.SelectedIndex];
                tbxSupplier.Text = supplier.supplierName;
            }
            

        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            supplier.supplierName = tbxSupplier.Text;
            updateData();
        }

        private void BtnHapus_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resMess = System.Windows.MessageBox
                .Show("Hapus Supplier ?", "Delete Confirmation",
                    System.Windows.MessageBoxButton.YesNo);
            if (resMess == MessageBoxResult.Yes)
            {
                supplier.isDel = true;
                updateData();
                MessageBox.Show("Supplier dihapus");
            }
            
            
        }

        private void updateData()
        {
            using (var unitOfWork = new UnitOfWork(new SembakoContext()))
            {
                unitOfWork.Supplier.update(supplier);
                unitOfWork.Complete();
                loadDataSupplier();
            }
        }
    }
}
