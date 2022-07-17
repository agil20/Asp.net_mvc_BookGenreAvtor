using Microsoft.EntityFrameworkCore.Migrations;

namespace ManyToMany.Migrations
{
    public partial class removenamesosialaccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SocialAccounts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SocialAccounts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
