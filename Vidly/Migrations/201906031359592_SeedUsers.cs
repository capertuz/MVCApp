namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8fde2afc-9dde-4a47-924b-d240fd44c00e', N'admin@vidly.com', 0, N'AGktqk+nNkFt5zw6Ey+xXGlyOGJ2U+mZAn4qJG1p8YYNedzzjwDk94Jmxhj2G5pu2Q==', N'1dfc8d88-5ea2-424f-8575-dc637ede47ce', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bf27e885-be88-4952-9be9-7bfa820e4db6', N'guest@vidly.com', 0, N'AMo8MX/DcyRHiF7/kr1M7oo33G0n6GSIXxrEPJmFYjeBNFxCmaA1mQLlT0QtjzvxHA==', N'775026d0-8cbb-406b-8340-2f43d3705566', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'03ecf92d-7dba-4737-b8b7-d18945a36f9e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8fde2afc-9dde-4a47-924b-d240fd44c00e', N'03ecf92d-7dba-4737-b8b7-d18945a36f9e')
");
        }
        
        public override void Down()
        {
        }
    }
}
