using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class Kategori
    {
        [Key]
        public int idKategori { get; set; }

        public string namaKategori { get; set; }

        public bool isDel { get; set; } = false;

        public virtual ICollection<Barang> barangs { get; set; }
    }
}
