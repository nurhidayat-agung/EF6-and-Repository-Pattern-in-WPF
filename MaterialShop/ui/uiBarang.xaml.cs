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
    /// Interaction logic for uiBarang.xaml
    /// </summary>
    public partial class uiBarang : Page
    {
        List<Kategori> kategoris = new List<Kategori>();
        List<Barang> barangs = new List<Barang>();
        List<String> listNamaKategori = new List<string>();
        Barang barang = new Barang();
        List<int> listIdKategori = new List<int>();

        public uiBarang()
        {
            InitializeComponent();
            loadKategori();
            loadBarang();
        }

        private void loadKategori()
        {
            using (var unitOfWork = new UnitOfWork(new SembakoContext()))
            {
                kategoris = new List<Kategori>(unitOfWork.Kategori.FindEntities(kategori1 => kategori1.isDel == false));
                
                kategoris.ForEach(kategori =>
                {
                    listNamaKategori.Add(kategori.namaKategori);
                    listIdKategori.Add(kategori.idKategori);
                });
                cbxKategori.ItemsSource = listNamaKategori;
                if (listNamaKategori.Count > 0)
                {
                    cbxKategori.SelectedIndex = 0;
                }
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (var unitOfWork = new UnitOfWork(new SembakoContext()))
            {
                barang = new Barang();
                barang.namaBarang = tbxNamaBarang.Text;
                barang.idBarang = int.Parse(tbxIdBarang.Text);
                Debug.WriteLine("idBarang : " + barang.idBarang);
                barang.harga = int.Parse(tbxHargaBarang.Text);
                barang.stok = int.Parse(tbxStok.Text);
                barang.idKategoriRefId = kategoris[cbxKategori.SelectedIndex].idKategori;
                barang.createDate = DateTime.Now;
                barang.isDel = false;
                unitOfWork.Barang.Add(barang);
                if (unitOfWork.Complete() > 0)
                {
                    loadBarang();
                    MessageBox.Show("insert berhasil");
                }
                
                
            }
        }

        private void loadBarang()
        {
            using (var unitOfWork = new UnitOfWork(new SembakoContext()))
            {
                barangs = new List<Barang>(unitOfWork.Barang.FindEntities(barang1 => barang1.isDel == false));
                dgBarang.ItemsSource = barangs;
            }
        }

        private void dgBarang_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dgBarang.SelectedIndex >= 0)
            {
                barang = barangs[dgBarang.SelectedIndex];
                loadBarangDetail(barang);
            }
        }

        private void loadBarangDetail(Barang b)
        {
            tbxIdBarang.Text = b.idBarang.ToString();
            tbxNamaBarang.Text = b.namaBarang;
            tbxHargaBarang.Text = b.harga.ToString();
            tbxStok.Text = b.stok.ToString();
            cbxKategori.SelectedIndex = listIdKategori.IndexOf(barang.idKategoriRefId);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            barang.namaBarang = tbxNamaBarang.Text;
            barang.stok = int.Parse(tbxStok.Text);
            barang.harga = int.Parse(tbxHargaBarang.Text);
            barang.idKategoriRefId = listIdKategori[cbxKategori.SelectedIndex];
            barang.UpdDate = DateTime.Now;
            using (var unitOfWork = new UnitOfWork(new SembakoContext()))
            {
                unitOfWork.Barang.update(barang);
                unitOfWork.Complete();
                loadBarang();
            }

        }

        private void btnHapus_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resMess = System.Windows.MessageBox
                .Show("Hapus Barang ?", "Delete Confirmation",
                    System.Windows.MessageBoxButton.YesNo);
            if (resMess == MessageBoxResult.Yes)
            {
                barang.isDel = true;
                barang.delDate = DateTime.Now;
                using (var unitOfWork = new UnitOfWork(new SembakoContext()))
                {
                    unitOfWork.Barang.update(barang);
                    unitOfWork.Complete();
                    loadBarang();
                }

                MessageBox.Show("hapus berhasil");
            }

            
        }

        private void TbxHargaBarang_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !UtilsApp.IsTextAllowed(e.Text);
        }

        private void TbxStok_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !UtilsApp.IsTextAllowed(e.Text);

        }

        private void BtnCari_OnClick(object sender, RoutedEventArgs e)
        {
            using (var uow = new UnitOfWork(new SembakoContext()))
            {
                barangs = uow.Barang.getBarangFromName(tbxCariBarang.Text);
                dgBarang.ItemsSource = barangs;
                dgBarang.Items.Refresh();
            }

        }
    }
}
