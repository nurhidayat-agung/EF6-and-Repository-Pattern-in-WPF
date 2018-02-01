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
    public class RepoDetJual : GeneralRepositories<DetailJual>, IRepoDetJual
    {
        public RepoDetJual(DbContext context) : base(context)
        {

        }
    }
}
