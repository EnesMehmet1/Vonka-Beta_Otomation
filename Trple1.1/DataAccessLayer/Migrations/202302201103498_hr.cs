namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.productSales", "receiptNo", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.productSales", "receiptNo", c => c.Int(nullable: false));
        }
    }
}
