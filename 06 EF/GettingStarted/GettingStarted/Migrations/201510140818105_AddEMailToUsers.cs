namespace GettingStarted.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEMailToUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "EMail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "EMail");
        }
    }
}
