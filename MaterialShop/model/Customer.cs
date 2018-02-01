using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class Customer
    {
        [Key]
        public int idCustomer { get; set; }

        public string namaCustomer { get; set; }

        public bool isDel { get; set; } = false;

        public ICollection<Penjualan> penjualans { get; set; }

    }
}
