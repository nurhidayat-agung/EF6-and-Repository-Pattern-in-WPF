using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class Barang
    {
        [Key]
        public int idBarang { get; set; }

        public string namaBarang { get; set; }

        public int stok { get; set; }

        public int harga { get; set; }

        public int idKategoriRefId { get; set; }

        [ForeignKey("idKategoriRefId")]
        public virtual Kategori kategori { get; set; }

        public DateTime? createDate { get; set; } = DateTime.Now;

        public DateTime? UpdDate { get; set; }

        public DateTime? delDate { get; set; }

        public bool isDel { get; set; } = false;

        public virtual ICollection<DetailBeli> detailBelis { get; set; }
        public virtual ICollection<DetailJual> detailJuals { get; set; }
    }
}
