namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class msf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.productSales", "price", c => c.Double(nullable: false));
            AddColumn("dbo.productSales", "prushPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.productSales", "prushPrice");
            DropColumn("dbo.productSales", "price");
        }
    }
}
