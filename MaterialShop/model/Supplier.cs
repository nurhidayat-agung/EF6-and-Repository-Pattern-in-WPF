using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SembakoShop.model
{
    public class Supplier
    {
        [Key]
        public int idSupplier { get; set; }

        public string supplierName { get; set; }

        public bool isDel { get; set; } = false;

        public virtual ICollection<DetailBeli> detailBelis { get; set; }
    }
}
