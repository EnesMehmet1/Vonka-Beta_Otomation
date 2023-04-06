namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mmf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "productpurchasePrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "productpurchasePrice");
        }
    }
}
