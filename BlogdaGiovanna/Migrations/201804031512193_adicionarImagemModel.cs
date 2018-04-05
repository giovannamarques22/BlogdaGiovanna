namespace BlogdaGiovanna.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicionarImagemModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "image");
        }
    }
}
