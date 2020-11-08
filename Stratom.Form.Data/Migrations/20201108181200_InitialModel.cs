﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Stratom.Form.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fiches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroFiche = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fiches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Souscription = table.Column<string>(type: "Text", nullable: true),
                    Autre = table.Column<string>(type: "Text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activites_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActiviteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Libelle = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiviteTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActiviteTypes_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_AssurancesDommage_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_AssurancesPersonne_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Concernes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Libelle = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concernes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Concernes_Fiches_FicheId",
                        column: x => x.FicheId,
                        principalTable: "Fiches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    DateSouscription = table.Column<DateTime>(type: "Date", nullable: false),
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
                    ContactOrigine = table.Column<string>(type: "Text", nullable: true),
                    ContactFaceAFace = table.Column<string>(type: "Text", nullable: true),
                    ContactTelephone = table.Column<string>(type: "Text", nullable: true),
                    ContactRole = table.Column<string>(type: "Text", nullable: true),
                    ContactFonction = table.Column<string>(type: "Text", nullable: true),
                    EntretienObjectifs = table.Column<string>(type: "Text", nullable: true),
                    EntretienDeroulement = table.Column<string>(type: "Text", nullable: true)
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
                name: "Etudiants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FicheId = table.Column<int>(nullable: false),
                    Nom = table.Column<string>(maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Etudiants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Etudiants_Fiches_FicheId",
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
                    Age = table.Column<int>(type: "int", nullable: true),
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
                    IsClient = table.Column<bool>(type: "bit", nullable: false),
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
                    Historique = table.Column<string>(type: "Text", nullable: true),
                    PresentationPortefeuilleClients = table.Column<string>(type: "Text", nullable: true),
                    ActivitesEntreprise = table.Column<string>(type: "Text", nullable: true),
                    Cible = table.Column<string>(type: "Text", nullable: true),
                    ActionsCommerciales = table.Column<string>(type: "Text", nullable: true),
                    ReductionsNature = table.Column<string>(type: "Text", nullable: true),
                    ReductionsMontant = table.Column<string>(type: "Text", nullable: true),
                    ReductionsPeriode = table.Column<string>(type: "Text", nullable: true),
                    ReductionsAutre = table.Column<string>(type: "Text", nullable: true)
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
                    InformationsAConserver = table.Column<string>(type: "Text", nullable: true),
                    PlanificationActions = table.Column<string>(type: "Text", nullable: true),
                    AutoEvaluation = table.Column<string>(type: "Text", nullable: true)
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
                    PhaseContact = table.Column<string>(type: "Text", nullable: true),
                    PhaseDecouverte = table.Column<string>(type: "Text", nullable: true),
                    PhaseTransition = table.Column<string>(type: "Text", nullable: true),
                    PhaseVente = table.Column<string>(type: "Text", nullable: true),
                    PhaseConclusion = table.Column<string>(type: "Text", nullable: true),
                    PhaseAsseoirVente = table.Column<string>(type: "Text", nullable: true),
                    PhasePriseConge = table.Column<string>(type: "Text", nullable: true)
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
                name: "IX_Activites_FicheId",
                table: "Activites",
                column: "FicheId");

            migrationBuilder.CreateIndex(
                name: "IX_ActiviteTypes_FicheId",
                table: "ActiviteTypes",
                column: "FicheId");

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
                name: "IX_Etudiants_FicheId",
                table: "Etudiants",
                column: "FicheId");

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
                name: "Activites");

            migrationBuilder.DropTable(
                name: "ActiviteTypes");

            migrationBuilder.DropTable(
                name: "AssurancesDommage");

            migrationBuilder.DropTable(
                name: "AssurancesPersonne");

            migrationBuilder.DropTable(
                name: "Concernes");

            migrationBuilder.DropTable(
                name: "ContratsPortefeuilles");

            migrationBuilder.DropTable(
                name: "DescriptionsActivite");

            migrationBuilder.DropTable(
                name: "Etudiants");

            migrationBuilder.DropTable(
                name: "FichesClientProspect");

            migrationBuilder.DropTable(
                name: "FichesContexteSimplifiee");

            migrationBuilder.DropTable(
                name: "FichesFin");

            migrationBuilder.DropTable(
                name: "Phases");

            migrationBuilder.DropTable(
                name: "Fiches");
        }
    }
}
