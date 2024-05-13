using Microsoft.EntityFrameworkCore.Migrations;

namespace spellScrollBackend.Migrations
{
    public partial class M001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Concentration = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ritual = table.Column<bool>(type: "bit", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Somatic = table.Column<bool>(type: "bit", nullable: false),
                    SpellName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
        }
    }
}
