namespace MyService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Link = c.String(),
                        Description = c.String(),
                        PubDate = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.NewId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.News");
        }
    }
}
