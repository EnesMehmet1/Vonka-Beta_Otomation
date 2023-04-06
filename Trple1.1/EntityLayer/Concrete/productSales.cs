using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class productSales
    {
        [Key]
        public long salesID { get; set; }
        public DateTime salesDate { get; set; }
        public int productAmount { get; set; }
        public double price { get; set; }
        public double prushPrice { get; set; }
        public long receiptNo { get; set; }

        public long Productid { get; set; }
        public virtual Product Product { get; set; }

        public int typeSalesId { get; set; }
        public virtual TypeSales TypeSales { get; set; }

        public long? cariId { get; set; }
        public virtual  Cari Cari { get; set; }

        public bool? paymentState { get; set; }
    }
}
