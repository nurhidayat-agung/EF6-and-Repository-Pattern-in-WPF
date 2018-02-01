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
    public class RepoKaryawan : GeneralRepositories<Karyawan>, IRepoKaryawan
    {
        public RepoKaryawan(DbContext context) : base(context)
        {
        }

        public List<Karyawan> login(int nik, string pass)
        {
            return Context.Set<Karyawan>().ToList().FindAll(karyawan => karyawan.NIK == nik && karyawan.password == pass);
        }
    }
}
