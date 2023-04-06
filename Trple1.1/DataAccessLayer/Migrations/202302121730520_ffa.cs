namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ffa : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.productSales");
            AlterColumn("dbo.productSales", "salesID", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.productSales", "salesID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.productSales");
            AlterColumn("dbo.productSales", "salesID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.productSales", "salesID");
        }
    }
}
