using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomLibrary.Migrations
{
    public partial class ABC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Users_UserID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_UserID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "ThisUserID",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_ThisUserID",
                table: "Book",
                column: "ThisUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Users_ThisUserID",
                table: "Book",
                column: "ThisUserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Users_ThisUserID",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_ThisUserID",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ThisUserID",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_UserID",
                table: "Book",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Users_UserID",
                table: "Book",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
