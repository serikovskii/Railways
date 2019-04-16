namespace Railways.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.Tickets", "TotalPrice", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Count", c => c.Int(nullable: false));
            AddColumn("dbo.Trains", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "FullName", c => c.String());
            AddColumn("dbo.Users", "NumberPhone", c => c.String());
            DropColumn("dbo.Tickets", "Price");
            DropColumn("dbo.Tickets", "Departure");
            DropColumn("dbo.Tickets", "Arrival");
            DropColumn("dbo.Tickets", "DateAndTime");
            DropColumn("dbo.Trains", "DateAndTime");
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "TicketId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "TicketId", c => c.Guid(nullable: false));
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.Trains", "DateAndTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tickets", "DateAndTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tickets", "Arrival", c => c.String());
            AddColumn("dbo.Tickets", "Departure", c => c.String());
            AddColumn("dbo.Tickets", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "NumberPhone");
            DropColumn("dbo.Users", "FullName");
            DropColumn("dbo.Trains", "Price");
            DropColumn("dbo.Tickets", "Count");
            DropColumn("dbo.Tickets", "TotalPrice");
            DropColumn("dbo.Tickets", "UserId");
        }
    }
}
