namespace FAIC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initProject2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "CategoryId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "CategoryId", c => c.String());
        }
    }
}
