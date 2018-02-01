using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class Karyawan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NIK { get; set; }

        public string namaKaryawan { get; set; }

        public string jabatan { get; set; }

        public string password { get; set; }

        public bool isDel { get; set; } = false;

        public virtual ICollection<Pembelian> pembelians { get; set; }

        public virtual ICollection<Penjualan> penjualans { get; set; }
    }
}
