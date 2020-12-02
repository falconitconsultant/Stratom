﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

namespace Persistance.Migrations
{
    [DbContext(typeof(StratomContext))]
    [Migration("20201201102411_updated_User_table_raltion")]
    partial class updated_User_table_raltion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.ActiviteTypes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("ActiviteTypes");
                });

            modelBuilder.Entity("Domain.Entities.Activites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssurancesDommage")
                        .HasColumnType("int");

                    b.Property<int?>("AssurancesPersonneId")
                        .HasColumnType("int");

                    b.Property<string>("Autre")
                        .HasColumnType("text");

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("Souscription")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AssurancesDommage");

                    b.HasIndex("AssurancesPersonneId");

                    b.HasIndex("FicheId");

                    b.ToTable("Activites");
                });

            modelBuilder.Entity("Domain.Entities.AssurancesDommage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autre")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("AssurancesDommage");
                });

            modelBuilder.Entity("Domain.Entities.AssurancesPersonne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autre")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("AssurancesPersonne");
                });

            modelBuilder.Entity("Domain.Entities.Concernes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("Concernes");
                });

            modelBuilder.Entity("Domain.Entities.ContratsPortefeuilles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autre")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("CotisationAnnuelle")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateSouscription")
                        .HasColumnType("date");

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("Garantie")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("ContratsPortefeuilles");
                });

            modelBuilder.Entity("Domain.Entities.DescriptionsActivite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactFaceAface")
                        .HasColumnName("ContactFaceAFace")
                        .HasColumnType("text");

                    b.Property<string>("ContactFonction")
                        .HasColumnType("text");

                    b.Property<string>("ContactOrigine")
                        .HasColumnType("text");

                    b.Property<string>("ContactRole")
                        .HasColumnType("text");

                    b.Property<string>("ContactTelephone")
                        .HasColumnType("text");

                    b.Property<string>("EntretienDeroulement")
                        .HasColumnType("text");

                    b.Property<string>("EntretienObjectifs")
                        .HasColumnType("text");

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("DescriptionsActivite");
                });

            modelBuilder.Entity("Domain.Entities.Fiches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActiviteTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("ActivitesId")
                        .HasColumnType("int");

                    b.Property<int?>("ConcernesId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroFiche")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ActiviteTypeId");

                    b.HasIndex("ActivitesId");

                    b.HasIndex("ConcernesId");

                    b.HasIndex("StudentId")
                        .HasName("IX_Fiches_student_id");

                    b.ToTable("Fiches");
                });

            modelBuilder.Entity("Domain.Entities.FichesClientProspect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresse")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AgesEnfants")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Anciennete")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Autre")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("CodePostal")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<bool>("IsClient")
                        .HasColumnType("bit");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NbEnfants")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Placements")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Revenus")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Sexe")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SituationFamiliale")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("SituationProfessionnelle")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Statut")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("TauxImposition")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Ville")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("FichesClientProspect");
                });

            modelBuilder.Entity("Domain.Entities.FichesContexteSimplifiee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionsCommerciales")
                        .HasColumnType("text");

                    b.Property<string>("ActivitesEntreprise")
                        .HasColumnType("text");

                    b.Property<string>("Cible")
                        .HasColumnType("text");

                    b.Property<string>("CompagnieMandante")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("EntrepriseNom")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("Historique")
                        .HasColumnType("text");

                    b.Property<string>("PresentationPortefeuilleClients")
                        .HasColumnType("text");

                    b.Property<string>("ReductionsAutre")
                        .HasColumnType("text");

                    b.Property<string>("ReductionsMontant")
                        .HasColumnType("text");

                    b.Property<string>("ReductionsNature")
                        .HasColumnType("text");

                    b.Property<string>("ReductionsPeriode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("FichesContexteSimplifiee");
                });

            modelBuilder.Entity("Domain.Entities.FichesFin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AutoEvaluation")
                        .HasColumnType("text");

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("InformationsAconserver")
                        .HasColumnName("InformationsAConserver")
                        .HasColumnType("text");

                    b.Property<string>("PlanificationActions")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("FichesFin");
                });

            modelBuilder.Entity("Domain.Entities.Phases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FicheId")
                        .HasColumnType("int");

                    b.Property<string>("PhaseAsseoirVente")
                        .HasColumnType("text");

                    b.Property<string>("PhaseConclusion")
                        .HasColumnType("text");

                    b.Property<string>("PhaseContact")
                        .HasColumnType("text");

                    b.Property<string>("PhaseDecouverte")
                        .HasColumnType("text");

                    b.Property<string>("PhasePriseConge")
                        .HasColumnType("text");

                    b.Property<string>("PhaseTransition")
                        .HasColumnType("text");

                    b.Property<string>("PhaseVente")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FicheId");

                    b.ToTable("Phases");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Entities.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Domain.Entities.Activites", b =>
                {
                    b.HasOne("Domain.Entities.AssurancesDommage", "AssurancesDommageNavigation")
                        .WithMany("Activites")
                        .HasForeignKey("AssurancesDommage")
                        .HasConstraintName("FK_Activites_AssurancesDommage");

                    b.HasOne("Domain.Entities.AssurancesPersonne", "AssurancesPersonne")
                        .WithMany("Activites")
                        .HasForeignKey("AssurancesPersonneId")
                        .HasConstraintName("FK_Activites_AssurancesPersonne");
                });

            modelBuilder.Entity("Domain.Entities.ContratsPortefeuilles", b =>
                {
                    b.HasOne("Domain.Entities.Fiches", "Fiche")
                        .WithMany("ContratsPortefeuilles")
                        .HasForeignKey("FicheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.DescriptionsActivite", b =>
                {
                    b.HasOne("Domain.Entities.Fiches", "Fiche")
                        .WithMany("DescriptionsActivite")
                        .HasForeignKey("FicheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Fiches", b =>
                {
                    b.HasOne("Domain.Entities.ActiviteTypes", "ActiviteType")
                        .WithMany("Fiches")
                        .HasForeignKey("ActiviteTypeId")
                        .HasConstraintName("FK_Fiches_ActiviteTypes1");

                    b.HasOne("Domain.Entities.Activites", "Activites")
                        .WithMany("Fiches")
                        .HasForeignKey("ActivitesId")
                        .HasConstraintName("FK_Fiches_Activites");

                    b.HasOne("Domain.Entities.Concernes", "Concernes")
                        .WithMany("Fiches")
                        .HasForeignKey("ConcernesId")
                        .HasConstraintName("FK_Fiches_Concernes");

                    b.HasOne("Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Domain.Entities.FichesClientProspect", b =>
                {
                    b.HasOne("Domain.Entities.Fiches", "Fiche")
                        .WithMany("FichesClientProspect")
                        .HasForeignKey("FicheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.FichesContexteSimplifiee", b =>
                {
                    b.HasOne("Domain.Entities.Fiches", "Fiche")
                        .WithMany("FichesContexteSimplifiee")
                        .HasForeignKey("FicheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.FichesFin", b =>
                {
                    b.HasOne("Domain.Entities.Fiches", "Fiche")
                        .WithMany("FichesFin")
                        .HasForeignKey("FicheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Phases", b =>
                {
                    b.HasOne("Domain.Entities.Fiches", "Fiche")
                        .WithMany("Phases")
                        .HasForeignKey("FicheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
