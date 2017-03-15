namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemeberShipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MemberShipType='Monthly' WHERE ID=2");
            Sql("UPDATE MembershipTypes SET MemberShipType='Quarterly' WHERE ID=3");
        }
        
        public override void Down()
        {
        }
    }
}
