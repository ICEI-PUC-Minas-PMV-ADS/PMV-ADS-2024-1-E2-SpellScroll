﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spells.Migrations
{
    public partial class M12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spell",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Classes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Concentration = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reach = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ritual = table.Column<bool>(type: "bit", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Somatic = table.Column<bool>(type: "bit", nullable: false),
                    SpellName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Verbal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.Id);
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spell");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}