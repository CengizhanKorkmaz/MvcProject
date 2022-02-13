namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1updatecategorystatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryStatus", c => c.Boolean(nullable: true));
        }

        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryStatus");
        }
    }
}
