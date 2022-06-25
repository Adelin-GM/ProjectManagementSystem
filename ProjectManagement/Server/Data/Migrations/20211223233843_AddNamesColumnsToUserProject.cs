using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.Server.Data.Migrations
{
    public partial class AddNamesColumnsToUserProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "UserProject",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "UserProject",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "UserProject");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "UserProject");
        }
    }
}
