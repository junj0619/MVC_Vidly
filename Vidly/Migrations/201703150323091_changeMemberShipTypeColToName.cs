namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeMemberShipTypeColToName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "MemberShipType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MemberShipType", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
