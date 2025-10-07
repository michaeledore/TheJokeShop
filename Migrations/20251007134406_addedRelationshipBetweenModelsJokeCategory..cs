using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheJokeShop.Migrations
{
    /// <inheritdoc />
    public partial class addedRelationshipBetweenModelsJokeCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Jokes",
                table: "Jokes");

            migrationBuilder.RenameTable(
                name: "Jokes",
                newName: "JokeList");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "JokeList",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "JokeList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JokeList",
                table: "JokeList",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_JokeList_CategoryId",
                table: "JokeList",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JokeList_Categories_CategoryId",
                table: "JokeList",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JokeList_Categories_CategoryId",
                table: "JokeList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JokeList",
                table: "JokeList");

            migrationBuilder.DropIndex(
                name: "IX_JokeList_CategoryId",
                table: "JokeList");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "JokeList");

            migrationBuilder.RenameTable(
                name: "JokeList",
                newName: "Jokes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Jokes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jokes",
                table: "Jokes",
                column: "ID");
        }
    }
}
