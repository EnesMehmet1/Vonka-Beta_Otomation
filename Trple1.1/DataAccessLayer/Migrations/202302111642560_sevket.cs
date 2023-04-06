namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sevket : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Brands", "CategoryDetail_CategoryDetailID", "dbo.CategoryDetails");
            DropIndex("dbo.Brands", new[] { "CategoryDetail_CategoryDetailID" });
            DropColumn("dbo.Brands", "CategoryDetail_CategoryDetailID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Brands", "CategoryDetail_CategoryDetailID", c => c.Int());
            CreateIndex("dbo.Brands", "CategoryDetail_CategoryDetailID");
            AddForeignKey("dbo.Brands", "CategoryDetail_CategoryDetailID", "dbo.CategoryDetails", "CategoryDetailID");
        }
    }
}
