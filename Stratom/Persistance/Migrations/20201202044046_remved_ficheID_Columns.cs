using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class remved_ficheID_Columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activites_AssurancesDommage",
                table: "Activites");

            migrationBuilder.DropIndex(
                name: "IX_Concernes_FicheId",
                table: "Concernes");

            migrationBuilder.DropIndex(
                name: "IX_AssurancesPersonne_FicheId",
                table: "AssurancesPersonne");

            migrationBuilder.DropIndex(
                name: "IX_AssurancesDommage_FicheId",
                table: "AssurancesDommage");

            migrationBuilder.DropIndex(
                name: "IX_ActiviteTypes_FicheId",
                table: "ActiviteTypes");

            migrationBuilder.DropIndex(
                name: "IX_Activites_AssurancesDommage",
                table: "Activites");

            migrationBuilder.DropColumn(
                name: "FicheId",
                table: "Concernes");

            migrationBuilder.DropColumn(
                name: "FicheId",
                table: "AssurancesPersonne");

            migrationBuilder.DropColumn(
                name: "FicheId",
                table: "AssurancesDommage");

            migrationBuilder.DropColumn(
                name: "FicheId",
                table: "ActiviteTypes");

            migrationBuilder.DropColumn(
                name: "AssurancesDommage",
                table: "Activites");

            migrationBuilder.AddColumn<int>(
                name: "AssurancesDommageId",
                table: "Activites",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activites_AssurancesDommageId",
                table: "Activites",
                column: "AssurancesDommageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activites_AssurancesDommage",
                table: "Activites",
                column: "AssurancesDommageId",
                principalTable: "AssurancesDommage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activites_AssurancesDommage",
                table: "Activites");

            migrationBuilder.DropIndex(
                name: "IX_Activites_AssurancesDommageId",
                table: "Activites");

            migrationBuilder.DropColumn(
                name: "AssurancesDommageId",
                table: "Activites");

            migrationBuilder.AddColumn<int>(
                name: "FicheId",
                table: "Concernes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FicheId",
                table: "AssurancesPersonne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FicheId",
                table: "AssurancesDommage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FicheId",
                table: "ActiviteTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AssurancesDommage",
                table: "Activites",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Concernes_FicheId",
                table: "Concernes",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_AssurancesPersonne_FicheId",
                table: "AssurancesPersonne",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_AssurancesDommage_FicheId",
                table: "AssurancesDommage",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_ActiviteTypes_FicheId",
                table: "ActiviteTypes",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_Activites_AssurancesDommage",
                table: "Activites",
                column: "AssurancesDommage");

            migrationBuilder.AddForeignKey(
                name: "FK_Activites_AssurancesDommage",
                table: "Activites",
                column: "AssurancesDommage",
                principalTable: "AssurancesDommage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
