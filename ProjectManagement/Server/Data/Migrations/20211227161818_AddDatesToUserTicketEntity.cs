using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManagement.Server.Data.Migrations
{
    public partial class AddDatesToUserTicketEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AssignedDate",
                table: "UserTicket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishedDate",
                table: "UserTicket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedDate",
                table: "UserTicket",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedDate",
                table: "UserTicket");

            migrationBuilder.DropColumn(
                name: "FinishedDate",
                table: "UserTicket");

            migrationBuilder.DropColumn(
                name: "StartedDate",
                table: "UserTicket");
        }
    }
}
