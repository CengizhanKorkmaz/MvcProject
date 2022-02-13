namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1_message_table_update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "SenderMail", c => c.String(maxLength: 70));
            DropColumn("dbo.Messages", "Sender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "Sender", c => c.String(maxLength: 70));
            DropColumn("dbo.Messages", "SenderMail");
        }
    }
}
