using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistance.Migrations
{
    public partial class added_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiviteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiviteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssurancesDommage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Libelle = table.Column<string>(maxLength: 100, nullable: false),
                    Autre = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssurancesDommage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssurancesPersonne",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Libelle = table.Column<string>(maxLength: 100, nullable: false),
                    Autre = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssurancesPersonne", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Concernes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concernes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Souscription = table.Column<string>(type: "text", nullable: true),
                    AssurancesPersonneId = table.Column<int>(nullable: true),
                    Autre = table.Column<string>(type: "text", nullable: true),
                    AssurancesDommage = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activites_AssurancesDommage",
                        column: x => x.AssurancesDommage,
                        principalTable: "AssurancesDommage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activites_AssurancesPersonne",
                        column: x => x.AssurancesPersonneId,
                        principalTable: "AssurancesPersonne",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fiches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroFiche = table.Column<int>(nullable: false),
                    ActiviteTypeId = table.Column<int>(nullable: true),
                    StudentId = table.Column<string>(nullable: true),
                    ConcernesId = table.Column<int>(nullable: true),
                    ActivitesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fiches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fiches_ActiviteTypes1",
                        column: x => x.ActiviteTypeId,
                        principalTable: "ActiviteTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fiches_Activites",
                        column: x => x.ActivitesId,
                        principalTable: "Activites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fiches_Concernes",
                        column: x => x.ConcernesId,
                        principalTable: "Concernes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratsPortefeuilles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: true),
                    Garantie = table.Column<string>(maxLength: 255, nullable: true),
                    DateSouscription = table.Column<DateTime>(type: "date", nullable: false),
                    CotisationAnnuelle = table.Column<string>(maxLength: 255, nullable: true),
                    Autre = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratsPortefeuilles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratsPortefeuilles_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DescriptionsActivite",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    ContactOrigine = table.Column<string>(type: "text", nullable: true),
                    ContactFaceAFace = table.Column<string>(type: "text", nullable: true),
                    ContactTelephone = table.Column<string>(type: "text", nullable: true),
                    ContactRole = table.Column<string>(type: "text", nullable: true),
                    ContactFonction = table.Column<string>(type: "text", nullable: true),
                    EntretienObjectifs = table.Column<string>(type: "text", nullable: true),
                    EntretienDeroulement = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionsActivite", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DescriptionsActivite_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FichesClientProspect",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(maxLength: 100, nullable: true),
                    Prenom = table.Column<string>(maxLength: 100, nullable: true),
                    Sexe = table.Column<string>(maxLength: 10, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Adresse = table.Column<string>(maxLength: 255, nullable: true),
                    CodePostal = table.Column<string>(maxLength: 10, nullable: true),
                    Ville = table.Column<string>(maxLength: 100, nullable: true),
                    Telephone = table.Column<string>(maxLength: 20, nullable: true),
                    Mobile = table.Column<string>(maxLength: 20, nullable: true),
                    Mail = table.Column<string>(maxLength: 50, nullable: true),
                    Autre = table.Column<string>(maxLength: 255, nullable: true),
                    SituationFamiliale = table.Column<string>(maxLength: 255, nullable: true),
                    NbEnfants = table.Column<string>(maxLength: 150, nullable: true),
                    AgesEnfants = table.Column<string>(maxLength: 150, nullable: true),
                    SituationProfessionnelle = table.Column<string>(maxLength: 255, nullable: true),
                    IsClient = table.Column<bool>(nullable: false),
                    Statut = table.Column<string>(maxLength: 150, nullable: true),
                    Anciennete = table.Column<string>(maxLength: 150, nullable: true),
                    Revenus = table.Column<string>(maxLength: 150, nullable: true),
                    TauxImposition = table.Column<string>(maxLength: 150, nullable: true),
                    Placements = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichesClientProspect", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichesClientProspect_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FichesContexteSimplifiee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    EntrepriseNom = table.Column<string>(maxLength: 150, nullable: true),
                    CompagnieMandante = table.Column<string>(maxLength: 150, nullable: true),
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
                    table.PrimaryKey("PK_FichesContexteSimplifiee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichesContexteSimplifiee_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FichesFin",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    InformationsAConserver = table.Column<string>(type: "text", nullable: true),
                    PlanificationActions = table.Column<string>(type: "text", nullable: true),
                    AutoEvaluation = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FichesFin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FichesFin_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
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
                        name: "FK_Phases_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activites_AssurancesDommage",
                table: "Activites",
                column: "AssurancesDommage");

            migrationBuilder.CreateIndex(
                name: "IX_Activites_AssurancesPersonneId",
                table: "Activites",
                column: "AssurancesPersonneId");

            migrationBuilder.CreateIndex(
                name: "IX_Activites_FicheId",
                table: "Activites",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_ActiviteTypes_FicheId",
                table: "ActiviteTypes",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssurancesDommage_FicheId",
                table: "AssurancesDommage",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_AssurancesPersonne_FicheId",
                table: "AssurancesPersonne",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_Concernes_FicheId",
                table: "Concernes",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratsPortefeuilles_FicheId",
                table: "ContratsPortefeuilles",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_DescriptionsActivite_FicheId",
                table: "DescriptionsActivite",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_Fiches_ActiviteTypeId",
                table: "Fiches",
                column: "ActiviteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fiches_ActivitesId",
                table: "Fiches",
                column: "ActivitesId");

            migrationBuilder.CreateIndex(
                name: "IX_Fiches_ConcernesId",
                table: "Fiches",
                column: "ConcernesId");

            migrationBuilder.CreateIndex(
                name: "IX_Fiches_student_id",
                table: "Fiches",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_FichesClientProspect_FicheId",
                table: "FichesClientProspect",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_FichesContexteSimplifiee_FicheId",
                table: "FichesContexteSimplifiee",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_FichesFin_FicheId",
                table: "FichesFin",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_Phases_FicheId",
                table: "Phases",
                column: "FicheId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContratsPortefeuilles");

            migrationBuilder.DropTable(
                name: "DescriptionsActivite");

            migrationBuilder.DropTable(
                name: "FichesClientProspect");

            migrationBuilder.DropTable(
                name: "FichesContexteSimplifiee");

            migrationBuilder.DropTable(
                name: "FichesFin");

            migrationBuilder.DropTable(
                name: "Phases");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Fiches");

            migrationBuilder.DropTable(
                name: "ActiviteTypes");

            migrationBuilder.DropTable(
                name: "Activites");

            migrationBuilder.DropTable(
                name: "Concernes");

            migrationBuilder.DropTable(
                name: "AssurancesDommage");

            migrationBuilder.DropTable(
                name: "AssurancesPersonne");
        }
    }
}
