namespace FAIC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initProject : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        SupplierId = c.String(),
                        CategoryId = c.String(),
                        QuantityPerUnit = c.String(),
                        UnitPrice = c.String(),
                        UnitsInStock = c.String(),
                        UnitsOnOrder = c.String(),
                        ReorderLevel = c.String(),
                        Discontinued = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
