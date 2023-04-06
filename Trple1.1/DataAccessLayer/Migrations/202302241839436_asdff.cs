namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdff : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductStocks", "Barcod", "dbo.Products");
            DropForeignKey("dbo.productSales", "Barcod", "dbo.Products");
            DropIndex("dbo.ProductStocks", new[] { "Barcod" });
            RenameColumn(table: "dbo.productSales", name: "Barcod", newName: "Productid");
            RenameIndex(table: "dbo.productSales", name: "IX_Barcod", newName: "IX_Productid");
            DropPrimaryKey("dbo.Products");
            AddColumn("dbo.Products", "Productid", c => c.Long(nullable: false, identity: true));
            AddColumn("dbo.ProductStocks", "Product_Productid", c => c.Long());
            AlterColumn("dbo.Products", "Barcod", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.Products", "Productid");
            CreateIndex("dbo.ProductStocks", "Product_Productid");
            AddForeignKey("dbo.ProductStocks", "Product_Productid", "dbo.Products", "Productid");
            AddForeignKey("dbo.productSales", "Productid", "dbo.Products", "Productid", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.productSales", "Productid", "dbo.Products");
            DropForeignKey("dbo.ProductStocks", "Product_Productid", "dbo.Products");
            DropIndex("dbo.ProductStocks", new[] { "Product_Productid" });
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Barcod", c => c.Long(nullable: false, identity: true));
            DropColumn("dbo.ProductStocks", "Product_Productid");
            DropColumn("dbo.Products", "Productid");
            AddPrimaryKey("dbo.Products", "Barcod");
            RenameIndex(table: "dbo.productSales", name: "IX_Productid", newName: "IX_Barcod");
            RenameColumn(table: "dbo.productSales", name: "Productid", newName: "Barcod");
            CreateIndex("dbo.ProductStocks", "Barcod");
            AddForeignKey("dbo.productSales", "Barcod", "dbo.Products", "Barcod", cascadeDelete: true);
            AddForeignKey("dbo.ProductStocks", "Barcod", "dbo.Products", "Barcod", cascadeDelete: true);
        }
    }
}
