using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        public DbSet<MarketCustomerProfile> MarketCustomerProfiles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<productSales> ProductSales { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryDetail> CategoryDetail { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<TypeSales> TypeSales { get; set; }
        public DbSet<Cari> Caris { get; set; }
    }
}
