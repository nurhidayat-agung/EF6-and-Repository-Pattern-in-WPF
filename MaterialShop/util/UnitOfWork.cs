using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialShop.iRepositories;
using MaterialShop.Repositories;

namespace MaterialShop.util
{
    class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SembakoContext _context;

        public UnitOfWork(SembakoContext context)
        {
            _context = context;
            Kategori = new KategoriRepositori(_context);
            Supplier = new SupplierRepo(_context);
            Barang = new BarangRepo(_context);
            Pembelian = new RepoPembelian(_context);
            DetailBeli = new RepoDetBeli(_context);
            Customer = new RepoCustomer(_context);
            Jual = new RepoJual(_context);
            DetJual = new RepoDetJual(_context);
            Karyawan = new RepoKaryawan(_context);
        }

        public IRepoKategori Kategori { get; }

        public IRepoSupplier Supplier { get; }

        public IRepoBarang Barang { get; }

        public IRepoPembelian Pembelian { get; }

        public IRepoDetBeli DetailBeli { get; }

        public IRepoCustomer Customer { get; }

        public IRepoJual Jual { get; set; }

        public IRepoDetJual DetJual { get;set; }

        public IRepoKaryawan Karyawan { get ;}

        public int Complete()
        {
            return _context.SaveChanges();
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
