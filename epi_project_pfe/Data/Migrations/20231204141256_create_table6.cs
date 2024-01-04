using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace epi_project_pfe.Data.Migrations
{
    public partial class create_table6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PFE_ETUDIANT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PfeId = table.Column<int>(type: "int", nullable: false),
                    EtudiantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFE_ETUDIANT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PFE_ETUDIANT_Etudiant_EtudiantId",
                        column: x => x.EtudiantId,
                        principalTable: "Etudiant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PFE_ETUDIANT_PFE_PfeId",
                        column: x => x.PfeId,
                        principalTable: "PFE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PFE_ETUDIANT_EtudiantId",
                table: "PFE_ETUDIANT",
                column: "EtudiantId");

            migrationBuilder.CreateIndex(
                name: "IX_PFE_ETUDIANT_PfeId",
                table: "PFE_ETUDIANT",
                column: "PfeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PFE_ETUDIANT");
        }
    }
}
