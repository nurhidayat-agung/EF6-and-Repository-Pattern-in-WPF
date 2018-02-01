using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialShop.iRepositories;
using MaterialShop.util;
using SembakoShop.model;

namespace MaterialShop.Repositories
{
    public class KategoriRepositori : GeneralRepositories<Kategori>,IRepoKategori
    {
        public KategoriRepositori(DbContext context) : base(context)
        {
        }

        public List<Barang> getBarangFromKategori(int id)
        {
            throw new NotImplementedException();
        }

        public SembakoContext SembakoContext
        {
            get { return Context as SembakoContext; }
        }
    }
}
