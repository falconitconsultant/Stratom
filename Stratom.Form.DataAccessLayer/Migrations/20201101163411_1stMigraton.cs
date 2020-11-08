using Microsoft.EntityFrameworkCore.Migrations;

namespace Stratom.Form.DataAccessLayer.Migrations
{
    public partial class _1stMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fiche",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(nullable: false),
                    ActiviteType = table.Column<bool>(nullable: false),
                    Concerne = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fiche", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Souscription = table.Column<string>(nullable: false),
                    Autre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activite_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssuranceDommage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Libelle = table.Column<string>(nullable: false),
                    Autre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssuranceDommage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssuranceDommage_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssurancePersonne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(nullable: false),
                    Autre = table.Column<string>(nullable: true),
                    FicheId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssurancePersonne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssurancePersonne_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratsPortefeuille",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Garantie = table.Column<string>(nullable: true),
                    DateSouscription = table.Column<string>(nullable: true),
                    CotisationAnnuelle = table.Column<string>(nullable: true),
                    Autre = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratsPortefeuille", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratsPortefeuille_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescriptionActivite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    NumeroFiche = table.Column<int>(nullable: false),
                    ContactOrigine = table.Column<string>(type: "text", nullable: true),
                    ContactFaceAface = table.Column<string>(type: "text", nullable: true),
                    ContactTelephone = table.Column<string>(type: "text", nullable: true),
                    ContactRole = table.Column<string>(type: "text", nullable: true),
                    ContactFonction = table.Column<string>(type: "text", nullable: true),
                    EntretienObjectifs = table.Column<string>(type: "text", nullable: true),
                    EntretienDeroulement = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionActivite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DescriptionActivite_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Etudiant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etudiant_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FicheClientProspect",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    NumeroFiche = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Sexe = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    Adresse = table.Column<string>(nullable: true),
                    CodePostal = table.Column<string>(nullable: true),
                    Ville = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Autre = table.Column<string>(type: "text", nullable: true),
                    SituationFamiliale = table.Column<string>(nullable: true),
                    NbEnfants = table.Column<string>(nullable: true),
                    AgesEnfants = table.Column<string>(nullable: true),
                    SituationProfessionnelle = table.Column<string>(type: "text", nullable: true),
                    IsClient = table.Column<bool>(nullable: false),
                    Statut = table.Column<string>(nullable: true),
                    Anciennete = table.Column<string>(nullable: true),
                    ContratsPortefeuilleId = table.Column<int>(nullable: false),
                    Revenus = table.Column<int>(nullable: false),
                    TauxImposition = table.Column<int>(nullable: false),
                    Placements = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FicheClientProspect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FicheClientProspect_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FicheContexteSimplifiee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    NumeroFiche = table.Column<int>(nullable: false),
                    EntrepriseNom = table.Column<string>(nullable: true),
                    CompagnieMandante = table.Column<string>(nullable: true),
                    Historique = table.Column<string>(type: "text", nullable: true),
                    PresentationPortefeuilleClients = table.Column<string>(type: "text", nullable: true),
                    ActivitesEntreprise = table.Column<string>(type: "text", nullable: true),
                    Cible = table.Column<string>(type: "text", nullable: true),
                    ActionsCommerciales = table.Column<string>(type: "text", nullable: true),
                    ReductionsNature = table.Column<string>(type: "text", nullable: true),
                    ReductionsMontant = table.Column<string>(type: "text", nullable: true),
                    ReductionsPeriode = table.Column<string>(type: "text", nullable: true),
                    ReductionsAutre = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FicheContexteSimplifiee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FicheContexteSimplifiee_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FicheFin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    NumeroFiche = table.Column<int>(nullable: false),
                    InformationsAConserver = table.Column<string>(type: "text", nullable: true),
                    PlanificationActions = table.Column<string>(type: "text", nullable: true),
                    AutoEvaluation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FicheFin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FicheFin_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Phases",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    NumeroFiche = table.Column<int>(nullable: false),
                    PhaseContact = table.Column<string>(type: "text", nullable: true),
                    PhaseDecouverte = table.Column<string>(type: "text", nullable: true),
                    PhaseTransition = table.Column<string>(type: "text", nullable: true),
                    PhaseVente = table.Column<string>(type: "text", nullable: true),
                    PhaseConclusion = table.Column<string>(type: "text", nullable: true),
                    PhaseAsseoirVente = table.Column<string>(type: "text", nullable: true),
                    PhasePriseConge = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phases_Fiche_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiche",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activite_FicheId",
                table: "Activite",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_AssuranceDommage_FicheId",
                table: "AssuranceDommage",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_AssurancePersonne_FicheId",
                table: "AssurancePersonne",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratsPortefeuille_FicheId",
                table: "ContratsPortefeuille",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionActivite_FicheId",
                table: "DescriptionActivite",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_Etudiant_FicheId",
                table: "Etudiant",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheClientProspect_FicheId",
                table: "FicheClientProspect",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheContexteSimplifiee_FicheId",
                table: "FicheContexteSimplifiee",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheFin_FicheId",
                table: "FicheFin",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_Phases_FicheId",
                table: "Phases",
                column: "FicheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activite");

            migrationBuilder.DropTable(
                name: "AssuranceDommage");

            migrationBuilder.DropTable(
                name: "AssurancePersonne");

            migrationBuilder.DropTable(
                name: "ContratsPortefeuille");

            migrationBuilder.DropTable(
                name: "DescriptionActivite");

            migrationBuilder.DropTable(
                name: "Etudiant");

            migrationBuilder.DropTable(
                name: "FicheClientProspect");

            migrationBuilder.DropTable(
                name: "FicheContexteSimplifiee");

            migrationBuilder.DropTable(
                name: "FicheFin");

            migrationBuilder.DropTable(
                name: "Phases");

            migrationBuilder.DropTable(
                name: "Fiche");
        }
    }
}
