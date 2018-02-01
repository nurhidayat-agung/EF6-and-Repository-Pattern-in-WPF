using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class Pembelian
    {
        [Key]
        public int idPembelian { get; set; }

        public string namaPembelian { get; set; }

        public DateTime? tglBeli { get; set; } = DateTime.Now;

        public int NIKRefId { get; set; }

        [ForeignKey("NIKRefId")]
        public virtual Karyawan karyawans { get; set; }

        public virtual ICollection<DetailBeli> belis { get; set; }
    }
}
