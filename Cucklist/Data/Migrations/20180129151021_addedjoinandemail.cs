using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Cucklist.Data.Migrations
{
    public partial class addedjoinandemail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Join");

            migrationBuilder.AddColumn<int>(
                name: "EmailId",
                table: "Join",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    EmailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactOk = table.Column<bool>(nullable: false),
                    IsPrimary = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.EmailId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Join_EmailId",
                table: "Join",
                column: "EmailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Email_EmailId",
                table: "Join",
                column: "EmailId",
                principalTable: "Email",
                principalColumn: "EmailId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Join_Email_EmailId",
                table: "Join");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropIndex(
                name: "IX_Join_EmailId",
                table: "Join");

            migrationBuilder.DropColumn(
                name: "EmailId",
                table: "Join");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Join",
                nullable: true);
        }
    }
}
