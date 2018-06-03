namespace MvcNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRowVersionMig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewsItems", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewsItems", "RowVersion");
        }
    }
}
