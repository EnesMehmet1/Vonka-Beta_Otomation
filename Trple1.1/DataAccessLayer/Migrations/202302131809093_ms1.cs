namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ms1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "KDV", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "productPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "productPrice", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "KDV");
        }
    }
}
