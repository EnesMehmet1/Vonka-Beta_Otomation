namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ghn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "productpurchasePrice", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "stockNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "stockNumber", c => c.Int());
            AlterColumn("dbo.Products", "productpurchasePrice", c => c.Double());
        }
    }
}
