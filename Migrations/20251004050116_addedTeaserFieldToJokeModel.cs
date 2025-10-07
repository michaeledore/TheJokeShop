﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheJokeShop.Migrations
{
    /// <inheritdoc />
    public partial class addedTeaserFieldToJokeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Teaser",
                table: "Jokes",
                type: "nvarchar(325)",
                maxLength: 325,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Teaser",
                table: "Jokes");
        }
    }
}
