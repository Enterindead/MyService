namespace MyService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateToString : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Enclosure_Url", c => c.String());
            AddColumn("dbo.News", "Enclosure_Length", c => c.Int(nullable: false));
            AddColumn("dbo.News", "Enclosure_Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "Enclosure_Type");
            DropColumn("dbo.News", "Enclosure_Length");
            DropColumn("dbo.News", "Enclosure_Url");
        }
    }
}
