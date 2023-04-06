namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mfo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Caris",
                c => new
                    {
                        cariId = c.Long(nullable: false, identity: true),
                        title = c.String(),
                        accountype = c.Boolean(nullable: false),
                        adress = c.String(),
                        province = c.String(),
                        district = c.String(),
                        taxcircle = c.String(),
                        VKN = c.Int(nullable: false),
                        carilimit = c.Int(nullable: false),
                        cariState = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.cariId);
            
            AddColumn("dbo.productSales", "cariId", c => c.Long());
            CreateIndex("dbo.productSales", "cariId");
            AddForeignKey("dbo.productSales", "cariId", "dbo.Caris", "cariId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.productSales", "cariId", "dbo.Caris");
            DropIndex("dbo.productSales", new[] { "cariId" });
            DropColumn("dbo.productSales", "cariId");
            DropTable("dbo.Caris");
        }
    }
}
