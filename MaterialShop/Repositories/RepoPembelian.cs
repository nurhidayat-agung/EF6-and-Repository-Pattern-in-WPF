using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialShop.iRepositories;
using SembakoShop.model;

namespace MaterialShop.Repositories
{
    class RepoPembelian : GeneralRepositories<Pembelian>, IRepoPembelian
    {
        public RepoPembelian(DbContext context) : base(context)
        {

        }


    }
}
