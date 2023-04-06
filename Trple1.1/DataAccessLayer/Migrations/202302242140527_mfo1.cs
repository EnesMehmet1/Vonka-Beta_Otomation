namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mfo1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caris", "date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Caris", "date");
        }
    }
}
