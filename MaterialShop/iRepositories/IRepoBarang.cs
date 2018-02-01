using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SembakoShop.model;

namespace MaterialShop.iRepositories
{
    public interface IRepoBarang : IRepoGeneral<Barang>
    {
        List<Barang> getBarangFromName(string name);

        List<Barang> getNotDel();

        List<Barang> getWithKat(string name);

        string getNamaFromId(int id);
    }
}
