namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ljgh : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "brandID", "dbo.Brands");
            DropForeignKey("dbo.Products", "categoryID", "dbo.Categories");
            DropForeignKey("dbo.Products", "CategoryDetailID", "dbo.CategoryDetails");
            DropIndex("dbo.Products", new[] { "brandID" });
            DropIndex("dbo.Products", new[] { "categoryID" });
            DropIndex("dbo.Products", new[] { "CategoryDetailID" });
            AlterColumn("dbo.Products", "productpurchasePrice", c => c.Double());
            AlterColumn("dbo.Products", "KDV", c => c.Int());
            AlterColumn("dbo.Products", "stockNumber", c => c.Int());
            AlterColumn("dbo.Products", "productWeight", c => c.Int());
            AlterColumn("dbo.Products", "brandID", c => c.Int());
            AlterColumn("dbo.Products", "categoryID", c => c.Int());
            AlterColumn("dbo.Products", "CategoryDetailID", c => c.Int());
            CreateIndex("dbo.Products", "brandID");
            CreateIndex("dbo.Products", "categoryID");
            CreateIndex("dbo.Products", "CategoryDetailID");
            AddForeignKey("dbo.Products", "brandID", "dbo.Brands", "brandID");
            AddForeignKey("dbo.Products", "categoryID", "dbo.Categories", "categoryID");
            AddForeignKey("dbo.Products", "CategoryDetailID", "dbo.CategoryDetails", "CategoryDetailID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryDetailID", "dbo.CategoryDetails");
            DropForeignKey("dbo.Products", "categoryID", "dbo.Categories");
            DropForeignKey("dbo.Products", "brandID", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "CategoryDetailID" });
            DropIndex("dbo.Products", new[] { "categoryID" });
            DropIndex("dbo.Products", new[] { "brandID" });
            AlterColumn("dbo.Products", "CategoryDetailID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "categoryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "brandID", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "productWeight", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "stockNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "KDV", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "productpurchasePrice", c => c.Double(nullable: false));
            CreateIndex("dbo.Products", "CategoryDetailID");
            CreateIndex("dbo.Products", "categoryID");
            CreateIndex("dbo.Products", "brandID");
            AddForeignKey("dbo.Products", "CategoryDetailID", "dbo.CategoryDetails", "CategoryDetailID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "categoryID", "dbo.Categories", "categoryID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "brandID", "dbo.Brands", "brandID", cascadeDelete: true);
        }
    }
}
