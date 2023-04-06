namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class afd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.productSales", "typeSalesId", "dbo.TypeSales");
            DropIndex("dbo.productSales", new[] { "typeSalesId" });
            AlterColumn("dbo.productSales", "typeSalesId", c => c.Int(nullable: false));
            CreateIndex("dbo.productSales", "typeSalesId");
            AddForeignKey("dbo.productSales", "typeSalesId", "dbo.TypeSales", "typeSalesId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.productSales", "typeSalesId", "dbo.TypeSales");
            DropIndex("dbo.productSales", new[] { "typeSalesId" });
            AlterColumn("dbo.productSales", "typeSalesId", c => c.Int());
            CreateIndex("dbo.productSales", "typeSalesId");
            AddForeignKey("dbo.productSales", "typeSalesId", "dbo.TypeSales", "typeSalesId");
        }
    }
}
