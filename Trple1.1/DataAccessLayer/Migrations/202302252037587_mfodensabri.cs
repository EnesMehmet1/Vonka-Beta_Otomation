namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mfodensabri : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Caris", "email", c => c.String());
            AddColumn("dbo.Caris", "managerPerson", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Caris", "managerPerson");
            DropColumn("dbo.Caris", "email");
        }
    }
}
