namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bf6e09e8-d487-4881-be5f-37bca287ae89', N'admin@vidly.com', 0, N'AEqHa+V7TCtQk5pLxg42gHkH6sTpgzesu5+63l8qW1VdeiyYyl4aV4o/+xfleF8phg==', N'b861d297-03ae-489a-b01e-d1c54f848781', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cc22a58b-002e-4477-8fd9-fbac4ff75575', N'guest@vidly.com', 0, N'AOtgxkEEB2Myhys6QAIDNSPQDkLozbF0jRnzqaVR9gE5RYoCo3n7r7WbThwpzoK6hA==', N'6f926b77-acdd-4f3a-b960-12d285a57123', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e378dc29-e197-47dd-9610-e7120c7661fd', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bf6e09e8-d487-4881-be5f-37bca287ae89', N'e378dc29-e197-47dd-9610-e7120c7661fd')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
