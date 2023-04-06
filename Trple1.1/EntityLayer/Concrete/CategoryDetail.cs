using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CategoryDetail
    {
        [Key]
        public int CategoryDetailID { get; set; }
        public string CategoryDetailName { get; set; }

        public int? categoryID { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Product> Product { get; set; }
    }
}
