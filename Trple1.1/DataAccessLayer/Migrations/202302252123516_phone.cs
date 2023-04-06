namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class phone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Caris", "phoneNumber", c => c.Long(nullable: false));
            AlterColumn("dbo.Caris", "phoneNumber2", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Caris", "phoneNumber2", c => c.Int(nullable: false));
            AlterColumn("dbo.Caris", "phoneNumber", c => c.Int(nullable: false));
        }
    }
}
