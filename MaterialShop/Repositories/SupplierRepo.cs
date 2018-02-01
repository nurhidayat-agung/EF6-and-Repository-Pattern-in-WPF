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
    class SupplierRepo : GeneralRepositories<Supplier>, IRepoSupplier
    {
        public SupplierRepo(DbContext context) : base(context)
        {
        }

        public List<Barang> getBarangFromSupplier(int a)
        {
            throw new NotImplementedException();
        }

        public SembakoContext SembakoContext
        {
            get { return Context as SembakoContext; }
        }
    }
}
