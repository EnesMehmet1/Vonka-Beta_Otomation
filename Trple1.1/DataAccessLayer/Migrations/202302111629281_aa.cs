namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        brandID = c.Int(nullable: false, identity: true),
                        brandName = c.Int(nullable: false),
                        categoryID = c.Int(),
                        CategoryDetail_CategoryDetailID = c.Int(),
                    })
                .PrimaryKey(t => t.brandID)
                .ForeignKey("dbo.Categories", t => t.categoryID)
                .ForeignKey("dbo.CategoryDetails", t => t.CategoryDetail_CategoryDetailID)
                .Index(t => t.categoryID)
                .Index(t => t.CategoryDetail_CategoryDetailID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        categoryID = c.Int(nullable: false, identity: true),
                        categoryName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.categoryID);
            
            CreateTable(
                "dbo.CategoryDetails",
                c => new
                    {
                        CategoryDetailID = c.Int(nullable: false, identity: true),
                        CategoryDetailName = c.Int(nullable: false),
                        categoryID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryDetailID)
                .ForeignKey("dbo.Categories", t => t.categoryID)
                .Index(t => t.categoryID);
            
            AddColumn("dbo.Products", "brandID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "categoryID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "CategoryDetailID", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "brandID");
            CreateIndex("dbo.Products", "categoryID");
            CreateIndex("dbo.Products", "CategoryDetailID");
            AddForeignKey("dbo.Products", "brandID", "dbo.Brands", "brandID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "categoryID", "dbo.Categories", "categoryID", cascadeDelete: true);
            AddForeignKey("dbo.Products", "CategoryDetailID", "dbo.CategoryDetails", "CategoryDetailID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryDetailID", "dbo.CategoryDetails");
            DropForeignKey("dbo.Products", "categoryID", "dbo.Categories");
            DropForeignKey("dbo.Products", "brandID", "dbo.Brands");
            DropForeignKey("dbo.CategoryDetails", "categoryID", "dbo.Categories");
            DropForeignKey("dbo.Brands", "CategoryDetail_CategoryDetailID", "dbo.CategoryDetails");
            DropForeignKey("dbo.Brands", "categoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryDetailID" });
            DropIndex("dbo.Products", new[] { "categoryID" });
            DropIndex("dbo.Products", new[] { "brandID" });
            DropIndex("dbo.CategoryDetails", new[] { "categoryID" });
            DropIndex("dbo.Brands", new[] { "CategoryDetail_CategoryDetailID" });
            DropIndex("dbo.Brands", new[] { "categoryID" });
            DropColumn("dbo.Products", "CategoryDetailID");
            DropColumn("dbo.Products", "categoryID");
            DropColumn("dbo.Products", "brandID");
            DropTable("dbo.CategoryDetails");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
        }
    }
}
