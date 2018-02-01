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

namespace MaterialShop.ui
{
    /// <summary>
    /// Interaction logic for uiPembelian.xaml
    /// </summary>
    public partial class uiPembelian : Page
    {
        List<Pembelian> pembelians = new List<Pembelian>();
        List<Barang> Barangs = new List<Barang>();
        Pembelian beli = new Pembelian();
        Barang barang = new Barang();
        List<DetailBeli> DetailBelis = new List<DetailBeli>();
        List<Supplier> Suppliers  = new List<Supplier>();
        private int idBeli = 0;


        public uiPembelian()
        {
            InitializeComponent();
            loadInitial();
            loadPembelian();
            loadKategori();
            
        }

        private void loadKategori()
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                Suppliers = new List<Supplier>(uow.Supplier.FindEntities(sup => sup.isDel == false));
                cbxSupplier.ItemsSource = Suppliers;
                if (cbxSupplier.Items.Count > 1)
                {
                    cbxSupplier.SelectedIndex = 0;
                }
            }
        }

        private void loadInitial()
        {
            pnlCariBarang.IsEnabled = false;
            pnlDetilBarang.IsEnabled = false;
            pnlDetilJml.IsEnabled = false;

        }

        private void BtnSave_OnClick(object sender, RoutedEventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SembakoContext()))
            {
                beli.namaPembelian = tbxNamaBeli.Text;
                beli.tglBeli = DateTime.Now;
                beli.NIKRefId = 1;
                unitOfWork.Pembelian.Add(beli);
                unitOfWork.Complete();
                loadPembelian();
                Debug.WriteLine("id pembelian : " + beli.idPembelian);
            }

        }

        private void loadPembelian()
        {
            using (var unitOfWork = new UnitOfWork(new SembakoContext()))
            {
                pembelians = (List<Pembelian>) unitOfWork.Pembelian.GetAll();
                dgPembelian.ItemsSource = pembelians;
                dgPembelian.Items.Refresh();
            }

        }

        private void btnCari_Click(object sender, RoutedEventArgs e)
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                Barangs = uow.Barang.getBarangFromName(tbxNamaBarang.Text);
                dgBarang.ItemsSource = Barangs;
            }
        }

        private void DgPembelian_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dgPembelian.SelectedIndex >= 0)
            {
                pnlCariBarang.IsEnabled = true;
                pnlDetilBarang.IsEnabled = true;
                beli = pembelians[dgPembelian.SelectedIndex];
                idBeli = beli.idPembelian;
                tbxNamaBeli.Text = beli.namaPembelian;
                // tbxTotalBayar.Text = beli.belis.Sum(detailBeli => detailBeli.barang.harga).ToString();
                // tbxTotalItem.Text = beli.belis.Sum(detailBeli => detailBeli.jmlBeli).ToString();
                loadDetilBeli();
            }
            
        }

        private void loadDetilBeli()
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                int totalBayar = 0;
                int totalItem = 0;
                DetailBelis = new List<DetailBeli>(uow.DetailBeli.FindEntities(detailBeli1 => detailBeli1.idBeliRefId == idBeli));
                DetailBelis.ForEach(detailBeli =>
                    {
                        Barang barang = uow.Barang.Get(detailBeli.idBarangRefId);
                        detailBeli.namaBarang = barang.namaBarang;
                        totalBayar += barang.harga * detailBeli.jmlBeli;
                        totalItem += detailBeli.jmlBeli;
                    });
                dgDetailBeli.ItemsSource = DetailBelis;
                dgDetailBeli.Items.Refresh();
                tbxTotalBayar.Text = totalBayar.ToString();
                tbxTotalItem.Text = totalItem.ToString();
            }

        }

        private void DgBarang_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            pnlDetilJml.IsEnabled = true;
            if (dgBarang.SelectedIndex >= 0 && dgBarang.SelectedIndex <= Barangs.Count)
            {
                barang = Barangs[dgBarang.SelectedIndex];
                tbxBarangDetil.Text = barang.namaBarang;
            }

        }

        private void btnTambahDetail_Click(object sender, RoutedEventArgs e)
        {
            DetailBeli detBeli = new DetailBeli();
            detBeli.idSupplierRefId = (int) cbxSupplier.SelectedValue;
            detBeli.idBarangRefId = barang.idBarang;
            detBeli.idBeliRefId = idBeli;
            detBeli.jmlBeli = int.Parse(tbxJmlBeli.Text);
            detBeli.namaBarang = barang.namaBarang;
            Debug.WriteLine("id Supplier : " + detBeli.idSupplierRefId);
            DetailBelis.Add(detBeli);
//            dgDetailBeli.Items.Clear();
            Debug.WriteLine("jumlah list detail beli : " + DetailBelis.Count);
            dgDetailBeli.ItemsSource = DetailBelis;
            dgDetailBeli.Items.Refresh();
            tbxTotalBayar.Text = (int.Parse(tbxTotalBayar.Text) +
                                  (barang.harga * int.Parse(tbxJmlBeli.Text))).ToString();
            tbxTotalItem.Text = (int.Parse(tbxTotalItem.Text) + int.Parse(tbxJmlBeli.Text)).ToString();

        }

        private void BtnPushDetailBeli_OnClick(object sender, RoutedEventArgs e)
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                DetailBelis.ForEach(detailBeli1 =>
                {
                    if (detailBeli1.idDetBeli < 1)
                    {
                        uow.DetailBeli.Add(detailBeli1);
                        uow.Complete();
                    }
                    
                });
                MessageBox.Show("input selesai");
            }

        }

        

        private void TbxJmlBeli_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !UtilsApp.IsTextAllowed(e.Text);
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                beli.namaPembelian = tbxNamaBeli.Text;
                uow.Pembelian.update(beli);
                uow.Complete();
                loadPembelian();
                MessageBox.Show("update pembelian berhasil");
            }

        }
    }
}
