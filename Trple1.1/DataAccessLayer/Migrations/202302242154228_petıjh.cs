namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class petıjh : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caris", "balance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Caris", "balance");
        }
    }
}
