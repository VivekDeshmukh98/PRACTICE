﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MYAPI_APIPractice.Migrations
{
    public partial class basic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
     name: "Products",
     columns: table => new
     {
         Id = table.Column<int>(nullable: false)
             .Annotation("SqlServer:Identity", "1, 1"),
         Name = table.Column<string>(nullable: true),
         Price = table.Column<decimal>(nullable: false)
     },
     constraints: table =>
     {
         table.PrimaryKey("PK_Products", x => x.Id);
     });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
