using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SembakoShop.model;

namespace MaterialShop.iRepositories
{
    public interface IRepoKategori : IRepoGeneral<Kategori>
    {
        List<Barang> getBarangFromKategori(int id);
    }
}
