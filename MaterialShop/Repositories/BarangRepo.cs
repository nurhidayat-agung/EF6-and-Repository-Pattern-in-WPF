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
    public class BarangRepo : GeneralRepositories<Barang>, IRepoBarang
    {
        public BarangRepo(DbContext context) : base(context)
        {
        }

        public List<Barang> getBarangFromName(string name)
        {
            return Context.Set<Barang>().ToList().FindAll(barang1 => barang1.namaBarang.Contains(name))
                .FindAll(barang3 => barang3.isDel == false );
        }

        public List<Barang> getNotDel()
        {
            return Context.Set<Barang>().ToList().FindAll(barang => barang.isDel == false);
        }

        public List<Barang> getWithKat(string name)
        {
            return Context.Set<Barang>().Where(barang2 => barang2.isDel == false)
                .Include(barang => barang.kategori).ToList().FindAll(barang3 => barang3.stok > 0)
                .FindAll(barang4 => barang4.namaBarang.Contains(name));
        }

        public string getNamaFromId(int id)
        {
            Barang barang = Context.Set<Barang>().Find(id);
            return barang.namaBarang;
        }
    }
}
