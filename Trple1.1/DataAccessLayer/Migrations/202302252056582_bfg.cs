namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bfg : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Caris", "managerPerson", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Caris", "managerPerson", c => c.Int(nullable: false));
        }
    }
}
