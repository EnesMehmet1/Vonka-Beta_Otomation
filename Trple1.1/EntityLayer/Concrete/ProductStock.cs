using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductStock
    {
        [Key]
        public int StockId { get; set; }
        public int StockNumber { get; set; }

        public long Barcod { get; set; }
        public virtual Product Product { get; set; }
    }
}
