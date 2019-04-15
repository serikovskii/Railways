namespace Railways.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitNew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TrainId = c.Guid(nullable: false),
                        Price = c.Int(nullable: false),
                        Departure = c.String(),
                        Arrival = c.String(),
                        DateAndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trains",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Path = c.String(),
                        Date = c.DateTime(nullable: false),
                        Capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Inn = c.String(),
                        TicketId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Trains");
            DropTable("dbo.Tickets");
        }
    }
}
