namespace FAIC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSeeder : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "QuantityPerUnit", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "UnitPrice", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "UnitPrice", c => c.String());
            AlterColumn("dbo.Products", "QuantityPerUnit", c => c.String());
        }
    }
}
