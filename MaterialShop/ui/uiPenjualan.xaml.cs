using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Debug = System.Diagnostics.Debug;

namespace MaterialShop.ui
{
    /// <summary>
    /// Interaction logic for uiPenjualan.xaml
    /// </summary>
    public partial class uiPenjualan : Page
    {
        List<Barang> Barangs = new List<Barang>();
        List<Customer> Customers = new List<Customer>();
        Barang barang = new Barang();
        DetailJual detJual = new DetailJual();
        List<DetailJual> detailJuals = new List<DetailJual>();
        private int jmlBeli;

        public uiPenjualan()
        {
            InitializeComponent();
            loadCustomer();
        }

        private void loadCustomer()
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                Customers = new List<Customer>(uow.Customer.GetAll());
                cbxCustomer.ItemsSource = Customers;
                if (cbxCustomer.Items.Count >= 0)
                {
                    cbxCustomer.SelectedIndex = 0;
                }
            }

        }

        private void BtnCari_OnClick(object sender, RoutedEventArgs e)
        {
            using (var unow = new UnitOfWork(new SembakoContext()))
            {
                Barangs = unow.Barang.getWithKat(tbxNamaBarang.Text);
                dgCariBarang.ItemsSource = Barangs;
                dgCariBarang.Items.Refresh();
                Debug.WriteLine("jumlah barang : " + Barangs.Count);
            }
            
        }

        private void DgCariBarang_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            barang = Barangs[dgCariBarang.SelectedIndex];
            tbxNamaDetail.Text = barang.namaBarang;
            
            Debug.WriteLine("idBarang barang : " + barang.idBarang);

        }

        private void btnToCart_Click(object sender, RoutedEventArgs e)
        {
            barang = Barangs[dgCariBarang.SelectedIndex];
            jmlBeli = 0;
            Debug.WriteLine("jumlah sama : " + detailJuals.FindAll(jual => jual.idBarangRefId == barang.idBarang).Count);
            jmlBeli = detailJuals.FindAll(jual => jual.idBarangRefId == barang.idBarang)
                          .Sum(jual => jual.jmlJual) + int.Parse(tbxJmlbeli.Text);
            if (jmlBeli <= barang.stok)
            {
                DetailJual juall =  new DetailJual();
                juall.idBarangRefId = barang.idBarang;
                juall.namaBarang = barang.namaBarang;
                juall.hargaBarang = (barang.harga + (barang.harga / 10)) * int.Parse(tbxJmlbeli.Text);
                juall.jmlJual = int.Parse(tbxJmlbeli.Text);
                detailJuals.Add(juall);
                dgCart.ItemsSource = detailJuals;
                dgCart.Items.Refresh();
                tbxTotalBayar.Text = detailJuals.Sum(jual => jual.hargaBarang).ToString();
            }
            else
            {
                MessageBox.Show("jumlahyang anda masukan terlalu banyak");
            }
        }

        private void btnJual_Click(object sender, RoutedEventArgs e)
        {
            tbxKembali.Text =  (int.Parse(tbxDibayar.Text) - int.Parse(tbxTotalBayar.Text)).ToString();
            if (int.Parse(tbxKembali.Text) >= 0)
            {
                MessageBoxResult resMess = System.Windows.MessageBox
                    .Show("Proses Transaksi ?", "Transaksion Confirmation",
                        System.Windows.MessageBoxButton.YesNo);
                if (resMess == MessageBoxResult.Yes)
                {

                    using (var uow = new UnitOfWork(new SembakoContext()))
                    {
                        Penjualan penjualan = new Penjualan();
                        penjualan.tglJual = DateTime.Now;
                        penjualan.idCustomerRefId = (int)cbxCustomer.SelectedValue;
                        penjualan.NIKRefId = 1;
                        uow.Jual.Add(penjualan);
                        uow.Complete();
                        foreach (DetailJual detailJual in detailJuals)
                        {
                            detailJual.idJualRefId = penjualan.idPenjualan;
                            uow.DetJual.Add(detailJual);
                            uow.Complete();
                        }

                        MessageBox.Show("insert sukses");
                    }

                    resetState();
                }
                else
                {
                    MessageBox.Show("uang pembayaran kurang");
                }
            }
            

        }

        private void resetState()
        {
            detailJuals.Clear();
            dgCart.ItemsSource = detailJuals;
            dgCart.Items.Refresh();
            tbxTotalBayar.Text = "";
            tbxKembali.Text = "";
            tbxDibayar.Text = "";
            tbxNamaDetail.Text = "";
            tbxJmlbeli.Text = "";


        }

        private void TbxJmlbeli_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !UtilsApp.IsTextAllowed(e.Text);
        }

        private void TbxDibayar_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !UtilsApp.IsTextAllowed(e.Text);
        }
    }
}
