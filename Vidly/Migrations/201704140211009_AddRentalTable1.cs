namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentalTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "Movie_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Rentals", "Movie_Id");
            AddForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Rentals", new[] { "Movie_Id" });
            DropColumn("dbo.Rentals", "Movie_Id");
        }
    }
}
