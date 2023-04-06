namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mfsa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MarketCustomerProfiles", "password", c => c.Double(nullable: false));
            AddColumn("dbo.MarketCustomerProfiles", "eMail", c => c.String());
            AddColumn("dbo.MarketCustomerProfiles", "state", c => c.Boolean(nullable: false));
            AddColumn("dbo.MarketCustomerProfiles", "userRole", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MarketCustomerProfiles", "userRole");
            DropColumn("dbo.MarketCustomerProfiles", "state");
            DropColumn("dbo.MarketCustomerProfiles", "eMail");
            DropColumn("dbo.MarketCustomerProfiles", "password");
        }
    }
}
