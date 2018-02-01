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
    /// Interaction logic for uiKategori.xaml
    /// </summary>
    public partial class uiKategori : Page
    {
        List<Kategori> kategoris = new List<Kategori>();
        Kategori kategori = new Kategori();
        public uiKategori()
        {
            InitializeComponent();
            loadKategori();
        }


        private void btnSave_Click_1(object sender, RoutedEventArgs e)
        {
            using (var unityOfWork = new UnitOfWork(new SembakoContext()))
            {
                
                kategori.namaKategori = tbxNik.Text;
                unityOfWork.Kategori.Add(kategori);
                unityOfWork.Complete();
                loadKategori();
            }
        }

        private void loadKategori()
        {
            using (var unityOfWork = new UnitOfWork(new SembakoContext()))
            {
                kategoris = new List<Kategori>(unityOfWork.Kategori.FindEntities(kategori1 => kategori1.isDel == false));
                dgContent.ItemsSource = kategoris;
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            kategori.namaKategori = tbxNik.Text;
            using (var unitOfWork = new UnitOfWork(new SembakoContext()))
            {
                unitOfWork.Kategori.update(kategori);
                unitOfWork.Complete();
                loadKategori();
            }

            MessageBox.Show("Update sukses");
        }

        private void DataGrid_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            
        }

        private void DgContent_OnSelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if (dgContent.SelectedIndex >= 0)
            {
                kategori = kategoris[dgContent.SelectedIndex];
                tbxNik.Text = kategori.namaKategori;
            }
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult resMess = System.Windows.MessageBox
                .Show("Hapus Kategori ?", "Delete Confirmation",
                    System.Windows.MessageBoxButton.YesNo);
            if (resMess == MessageBoxResult.Yes)
            {
                using (var unitOfWork = new UnitOfWork(new SembakoContext()))
                {
                    int a = kategori.idKategori;
                    Kategori kat = unitOfWork.Kategori.Get(a);
                    kat.isDel = true;
                    unitOfWork.Kategori.update(kat);
                    unitOfWork.Complete();
                    loadKategori();
                }

                MessageBox.Show("Hapus berhasil");
            }

            
        }
    }
}
