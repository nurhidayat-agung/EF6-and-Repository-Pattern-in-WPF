using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SembakoShop.model;

namespace MaterialShop.iRepositories
{
    public interface IRepoKaryawan : IRepoGeneral<Karyawan>
    {
        List<Karyawan> login(int nik, string pass);
    }
}
