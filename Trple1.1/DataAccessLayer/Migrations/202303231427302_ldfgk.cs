namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ldfgk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MarketCustomerProfiles", "password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MarketCustomerProfiles", "password", c => c.Double(nullable: false));
        }
    }
}
