namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admin_table_add_status : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "Status");
        }
    }
}
