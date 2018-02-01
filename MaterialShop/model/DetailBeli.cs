using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class DetailBeli
    {
        [Key]
        public int idDetBeli { get; set; }

        
        public int idBeliRefId { get; set; }

        [ForeignKey("idBeliRefId")]
        public virtual Pembelian pembelian { get; set; }

        public int idBarangRefId { get; set; }

        [ForeignKey("idBarangRefId")]
        public virtual Barang barang { get; set; }

        public int idSupplierRefId { get; set; }

        [ForeignKey("idSupplierRefId")]
        public virtual Supplier supplier { get; set; }

        public int jmlBeli { get; set; }

        [NotMapped]
        public string namaBarang { get; set; }
    }
}
