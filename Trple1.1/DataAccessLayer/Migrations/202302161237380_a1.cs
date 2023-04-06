namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "productpurchasePrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "productpurchasePrice", c => c.Int(nullable: false));
        }
    }
}
