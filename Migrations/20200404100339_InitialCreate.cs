using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonCaluculate.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type1 = table.Column<string>(nullable: true),
                    Type2 = table.Column<string>(nullable: true),
                    Ability1 = table.Column<string>(nullable: true),
                    Ability2 = table.Column<string>(nullable: true),
                    HiddenAbliity = table.Column<string>(nullable: true),
                    Hitpoint = table.Column<int>(nullable: false),
                    Attack = table.Column<int>(nullable: false),
                    Block = table.Column<int>(nullable: false),
                    Contact = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    EvolutionJudge = table.Column<bool>(nullable: false),
                    IconPass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemon");
        }
    }
}
