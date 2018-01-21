using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace midandfeed.Data.Migrations
{
    public partial class videoupnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "Body",
                table: "Video");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Video");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Video",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Video");

            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Video",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Body",
                table: "Video",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Video",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
