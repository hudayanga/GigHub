namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGeneredata : DbMigration 
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Name) VALUES('Rock')");
            Sql("INSERT INTO Genres(Name) VALUES('Jazz')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres" +
                "");
        }
    }
}
