namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Brands", "brandName", c => c.String());
            AlterColumn("dbo.Categories", "categoryName", c => c.String());
            AlterColumn("dbo.CategoryDetails", "CategoryDetailName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CategoryDetails", "CategoryDetailName", c => c.Int(nullable: false));
            AlterColumn("dbo.Categories", "categoryName", c => c.Int(nullable: false));
            AlterColumn("dbo.Brands", "brandName", c => c.Int(nullable: false));
        }
    }
}
