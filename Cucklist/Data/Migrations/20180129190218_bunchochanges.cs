using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cucklist.Data.Migrations
{
    public partial class bunchochanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactOk",
                table: "Email");

            migrationBuilder.DropColumn(
                name: "IsPrimary",
                table: "Email");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Email",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Email");

            migrationBuilder.AddColumn<bool>(
                name: "ContactOk",
                table: "Email",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                table: "Email",
                nullable: false,
                defaultValue: false);
        }
    }
}
