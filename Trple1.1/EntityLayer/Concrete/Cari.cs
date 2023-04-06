using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cari
    {
        [Key]
        public long cariId { get; set; }
        public string title { get; set; }
        public string accountype { get; set; } //1musteri 2kurum
        public string adress { get; set; }
        public string province { get; set; } //il
        public string district { get; set; } //ilçe
        public int taxcircle { get; set; } //vergi dairesi
        public int VKN { get; set; } //vkn
        public long phoneNumber { get; set; } //vkn
        public long phoneNumber2 { get; set; } //vkn
        public int carilimit { get; set; } //vkn
        public bool cariState { get; set; }
        public double balance { get; set; } //bakiye
        public string email { get; set; }
        public string managerPerson { get; set; }
        public DateTime date { get; set; }
        public ICollection<productSales> productSales { get; set; } 

    }
}
