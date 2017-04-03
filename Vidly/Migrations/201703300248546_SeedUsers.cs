namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1b1ba196-04e5-4144-8af0-8d243470d15e', N'admin@vidly.com', 0, N'AK53KPrZdqlKlFNPTQ1WhPcta8YTRDiwnYyvAbYG5FpkDnMLhZ7r+cpD59ncWKm20g==', N'582ad3a0-d1d6-4cab-9a4a-6ab949a09b16', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b7eeae4d-32eb-4ee2-ac7f-3399fb6f29fb', N'guest@Vildy.com', 0, N'APmNHKBuGpLi7kDeKpRZmuAla5jhs1mBBkZXpnvAwyXHldFHAWgWxCfixkVYJNv+HA==', N'a9f3aae1-479c-4dbb-a3e8-6eced3ec50f4', NULL, 0, 0, NULL, 1, 0, N'guest@Vildy.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'47e8af55-b8c5-4c04-848e-1a810f9e0105', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'1b1ba196-04e5-4144-8af0-8d243470d15e', N'47e8af55-b8c5-4c04-848e-1a810f9e0105')
                ");
        }

        public override void Down()
        {
        }
    }
}
