namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.productSales", "paymentState", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.productSales", "paymentState", c => c.Boolean(nullable: false));
        }
    }
}
