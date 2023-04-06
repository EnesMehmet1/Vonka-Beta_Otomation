using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public ICollection<CategoryDetail> CategoryDetail { get; set; }
        public ICollection<Brand> Brand { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
