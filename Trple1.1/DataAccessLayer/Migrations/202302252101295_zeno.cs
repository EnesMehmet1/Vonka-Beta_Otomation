namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zeno : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Caris", "taxcircle", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Caris", "taxcircle", c => c.String());
        }
    }
}
