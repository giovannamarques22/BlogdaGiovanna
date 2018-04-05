namespace BlogdaGiovanna.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class publicacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 500),
                        DateAdded = c.DateTime(nullable: false),
                        DateUpdate = c.DateTime(),
                        PostingBody = c.String(nullable: false, maxLength: 3000),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
