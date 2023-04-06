namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ms : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.productSales", "Barcod", "dbo.Products");
            DropForeignKey("dbo.ProductStocks", "Barcod", "dbo.Products");
            DropIndex("dbo.productSales", new[] { "Barcod" });
            DropIndex("dbo.ProductStocks", new[] { "Barcod" });
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Barcod", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.productSales", "Barcod", c => c.Long(nullable: false));
            AlterColumn("dbo.ProductStocks", "Barcod", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Products", "Barcod");
            CreateIndex("dbo.productSales", "Barcod");
            CreateIndex("dbo.ProductStocks", "Barcod");
            AddForeignKey("dbo.productSales", "Barcod", "dbo.Products", "Barcod", cascadeDelete: true);
            AddForeignKey("dbo.ProductStocks", "Barcod", "dbo.Products", "Barcod", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductStocks", "Barcod", "dbo.Products");
            DropForeignKey("dbo.productSales", "Barcod", "dbo.Products");
            DropIndex("dbo.ProductStocks", new[] { "Barcod" });
            DropIndex("dbo.productSales", new[] { "Barcod" });
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.ProductStocks", "Barcod", c => c.Int(nullable: false));
            AlterColumn("dbo.productSales", "Barcod", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Barcod", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Products", "Barcod");
            CreateIndex("dbo.ProductStocks", "Barcod");
            CreateIndex("dbo.productSales", "Barcod");
            AddForeignKey("dbo.ProductStocks", "Barcod", "dbo.Products", "Barcod", cascadeDelete: true);
            AddForeignKey("dbo.productSales", "Barcod", "dbo.Products", "Barcod", cascadeDelete: true);
        }
    }
}
