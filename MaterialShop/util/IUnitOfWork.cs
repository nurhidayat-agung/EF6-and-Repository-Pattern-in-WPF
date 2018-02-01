using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialShop.iRepositories;

namespace MaterialShop.util
{
    interface IUnitOfWork
    {
        IRepoKategori Kategori { get; }

        int Complete();

        void Dispose();
    }
}
