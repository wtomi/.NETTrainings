namespace MvcNews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewsItems", "Text", c => c.String(nullable: false, maxLength: 140));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewsItems", "Text", c => c.String());
        }
    }
}
