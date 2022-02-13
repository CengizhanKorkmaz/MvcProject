namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1_content_status_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contents", "ContentStatus", c => c.Boolean(nullable: true));
        }

        public override void Down()
        {
            DropColumn("dbo.Contents", "ContentStatus");
        }
    }
}
