namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MemberShipType='Pay as You Go' WHERE ID=1");
            Sql("UPDATE MembershipTypes SET MemberShipType='Weekly' WHERE ID=2");
            Sql("UPDATE MembershipTypes SET MemberShipType='Monthly' WHERE ID=3");
            Sql("UPDATE MembershipTypes SET MemberShipType='Annually' WHERE ID=4");
            
        }
        
        public override void Down()
        {
        }
    }
}
