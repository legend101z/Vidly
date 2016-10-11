namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9aeee3f2-1d38-4524-9ca4-101d297c7550', N'guest@vidly.com', 0, N'AG9IFEPuw8f57kM9Q1Tj9DJGEgtRXG63Z9Pp7+8QkrYdkGwE+SXbbM8Ea1wQngVzpQ==', N'c390637b-cdc0-43ec-8bc1-3701f4c92e6a', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ecd2b602-36d5-488a-b944-d252907b0202', N'admin@vidly.com', 0, N'AE0oj8NE7lcedyuZmTayYBeg9QQPlVEJm+kaiUp+aV0xSL6unyJGMIVMk9raGB61Dg==', N'6d976c71-3946-49e7-8cd1-24320735d8c4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                   INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b26ba8e3-a1ea-4353-9b78-458d9361ac4b', N'CanManageMovies')
                   INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ecd2b602-36d5-488a-b944-d252907b0202', N'b26ba8e3-a1ea-4353-9b78-458d9361ac4b')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
