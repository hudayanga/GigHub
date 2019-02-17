namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "Venue", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gigs", "Venue");
        }
    }
}
