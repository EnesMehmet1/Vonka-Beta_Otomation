using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public long Productid { get; set; }  //burada değişiklik yapıldı ve form2 de satış tablosuna ekleme kısmında
        public long Barcod { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public double productpurchasePrice { get; set; }  //incelenmesi gerekiyor(tür dönüşümü olmadığı için null(?) hatası veriyor)
        public int? KDV { get; set; }
        public int stockNumber { get; set; }              //incelenmesi gerekiyor(tür dönüşümü olmadığı için null(?) hatası veriyor)
        public int? productWeight { get; set; }
        public ICollection<productSales> productSales { get; set; }
        public ICollection<ProductStock> ProductStock { get; set; }

        public int? brandID { get; set; }
        public virtual Brand Brand { get; set; }

        public int? categoryID { get; set; }
        public virtual Category Category { get; set; }

        public int? CategoryDetailID { get; set; }
        public virtual CategoryDetail CategoryDetail { get; set; }
    }
}
