using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FasahnyBackEnd.Data.Migrations
{
    public partial class SeedAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // insert admmin in users table 
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES "
  +
                "(N'df894e58-39db-4741-aee1-7825d653c0f3', N'admin@admin.com', N'ADMIN@ADMIN.COM', N'admin@admin.com', N'ADMIN@ADMIN.COM', 0, N'AQAAAAEAACcQAAAAEP2YkLHkkdnDQ6DevTMIz1UrYq8UWKAJpra+eul/NMx/85GdvnLAgvQYNNVaxN9kcg==', N'FN66MOZOTZYVCT3LUOOJARTTS7ZFOO6G', N'829919ae-d28f-49f4-9ff1-98e6cedf6d00', NULL, 0, 0, NULL, 1, 0)");
            // insert Default Cities 
            migrationBuilder.Sql("SET IDENTITY_INSERT [dbo].[Cities] ON;"
                +
                "INSERT INTO[dbo].[Cities]([Id], [Name]) VALUES(1, N'القاهرة');"
                +
                "INSERT INTO[dbo].[Cities] ([Id], [Name]) VALUES(2, N'الاسكندرية');"
                +
                "SET IDENTITY_INSERT[dbo].[Cities] OFF;"); 

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //delete Admin
            migrationBuilder.Sql("Delete From [dbo].[AspNetUsers] where Id= 'df894e58-39db-4741-aee1-7825d653c0f3'");
            // delete default Cities 
            migrationBuilder.Sql("Delete From [dbo].[Cities] where Id in(1,2)");
        }
    }
}




