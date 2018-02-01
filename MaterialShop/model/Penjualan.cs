using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class Penjualan
    {
        [Key]
        public int idPenjualan { get; set; }

        public DateTime? tglJual { get; set; } = DateTime.Now;

        public int idCustomerRefId { get; set; }

        [ForeignKey("idCustomerRefId")]
        public virtual Customer customer { get; set; }

        public int NIKRefId { get; set; }

        [ForeignKey("NIKRefId")]
        public virtual Karyawan karyawan { get; set; }

        public virtual ICollection<DetailJual> juals { get; set; }
    }
}
