namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class egt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.productSales", "paymentState", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.productSales", "paymentState");
        }
    }
}
