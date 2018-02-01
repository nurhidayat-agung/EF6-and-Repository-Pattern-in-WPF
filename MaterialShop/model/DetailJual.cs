using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class DetailJual
    {
        [Key]
        public int idDetJual { get; set; }

        public int idJualRefId { get; set; }

        [ForeignKey("idJualRefId")]
        public virtual Penjualan penjualan { get; set; }

        public int idBarangRefId { get; set; }

        [ForeignKey("idBarangRefId")]
        public virtual Barang barang { get; set; }

        public int jmlJual { get; set; }

        [NotMapped]
        public string namaBarang { get; set; }

        [NotMapped]
        public int hargaBarang { get; set; }

    }
}
