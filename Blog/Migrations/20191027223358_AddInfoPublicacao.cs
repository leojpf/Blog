﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class AddInfoPublicacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data_Publicacao",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Publicado",
                table: "Posts",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data_Publicacao",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Publicado",
                table: "Posts");
        }
    }
}
