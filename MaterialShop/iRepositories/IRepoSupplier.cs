using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SembakoShop.model;

namespace MaterialShop.iRepositories
{
    interface IRepoSupplier : IRepoGeneral<Supplier>
    {
        List<Barang> getBarangFromSupplier(int a);
    }
}
