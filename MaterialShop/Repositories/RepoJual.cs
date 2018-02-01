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
    public class RepoJual : GeneralRepositories<Penjualan>,IRepoJual
    {
        public RepoJual(DbContext context) : base(context)
        {

        }
    }
}
