namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TypeSales",
                c => new
                    {
                        typeSalesId = c.Int(nullable: false, identity: true),
                        TypeSalesName = c.String(),
                    })
                .PrimaryKey(t => t.typeSalesId);
            
            AddColumn("dbo.productSales", "receiptNo", c => c.Int(nullable: false));
            AddColumn("dbo.productSales", "typeSalesId", c => c.Int());
            CreateIndex("dbo.productSales", "typeSalesId");
            AddForeignKey("dbo.productSales", "typeSalesId", "dbo.TypeSales", "typeSalesId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.productSales", "typeSalesId", "dbo.TypeSales");
            DropIndex("dbo.productSales", new[] { "typeSalesId" });
            DropColumn("dbo.productSales", "typeSalesId");
            DropColumn("dbo.productSales", "receiptNo");
            DropTable("dbo.TypeSales");
        }
    }
}
