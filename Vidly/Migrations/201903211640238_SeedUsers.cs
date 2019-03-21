namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'26119201-c6f8-47d2-b8e3-491ff5bc7c22', N'guest@vidly.com', 0, N'AFJ3Ju/Ys+VwKG37aGjA2qjaiGuN9uRgWwinpjxjUd1csh4m2L+5y26RppPmgmVjtw==', N'b659465d-aee4-4e69-aa05-5cc985d79c7e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3d467562-c898-4f31-bfa2-77fb7fb820d1', N'admin@vidly.com', 0, N'AN/rJZU/MZk7tU+CwPtAwcD1ejlnN67KblCVR9UAII84zVjjNXkiR7iQgRHRbmjIDA==', N'af5ed555-add5-49ac-adb3-cb651a0f430b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'85863e68-1b15-42ec-9c66-752b5e514af6', N'robertominghi@msn.com', 0, N'ANWQYoSfHyzBRL93yuaEQdunNF4Mt2/brj1lB1jAZoPTxN7GTBbSVPaMODTTfHulVA==', N'37472805-06a3-44d4-b377-ded62194a5db', NULL, 0, 0, NULL, 1, 0, N'robertominghi@msn.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0b911f72-7a70-42f1-991c-54e50b4f83cc', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3d467562-c898-4f31-bfa2-77fb7fb820d1', N'0b911f72-7a70-42f1-991c-54e50b4f83cc')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
