namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllowNulltoMovieTBCreatedDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "CreatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
