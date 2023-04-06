namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sevket2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.productSales", "productAmount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.productSales", "productAmount");
        }
    }
}
