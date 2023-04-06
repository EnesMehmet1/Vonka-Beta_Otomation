using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TypeSales
    {
        [Key]
        public int typeSalesId { get; set; }
        public string TypeSalesName { get; set; }
        public ICollection<productSales> productSales { get; set; }
    }
}
