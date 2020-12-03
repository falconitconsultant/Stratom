using System;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Persistance
{
    public partial class StratomContext : IdentityDbContext
    {
        //public StratomContext()
        //{
        //}

        public StratomContext(DbContextOptions<StratomContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiviteTypes> ActiviteTypes { get; set; }
        public virtual DbSet<Activites> Activites { get; set; }
        public virtual DbSet<AssurancesDommage> AssurancesDommage { get; set; }
        public virtual DbSet<AssurancesPersonne> AssurancesPersonne { get; set; }
        public virtual DbSet<Concernes> Concernes { get; set; }
        public virtual DbSet<ContratsPortefeuilles> ContratsPortefeuilles { get; set; }
        public virtual DbSet<DescriptionsActivite> DescriptionsActivite { get; set; }
        public virtual DbSet<Fiches> Fiches { get; set; }
        public virtual DbSet<FichesClientProspect> FichesClientProspect { get; set; }
        public virtual DbSet<FichesContexteSimplifiee> FichesContexteSimplifiee { get; set; }
        public virtual DbSet<FichesFin> FichesFin { get; set; }
        public virtual DbSet<Phases> Phases { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-FV1VV25;Database=Stratom;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ActiviteTypes>(entity =>
            //{
            //    entity.HasIndex(e => e.FicheId);
            //});

            modelBuilder.Entity<Activites>(entity =>
            {
                //entity.HasIndex(e => e.FicheId);

                entity.Property(e => e.Autre).HasColumnType("text");

                entity.Property(e => e.Souscription).HasColumnType("text");

                entity.HasOne(d => d.AssurancesDommageNavigation)
                    .WithMany(p => p.Activites)
                    //.HasForeignKey(d => d.AssurancesDommage)
                    .HasConstraintName("FK_Activites_AssurancesDommage");

                entity.HasOne(d => d.AssurancesPersonne)
                    .WithMany(p => p.Activites)
                    .HasForeignKey(d => d.AssurancesPersonneId)
                    .HasConstraintName("FK_Activites_AssurancesPersonne");
            });

            modelBuilder.Entity<AssurancesDommage>(entity =>
            {
                //entity.HasIndex(e => e.FicheId);

                entity.Property(e => e.Autre).HasMaxLength(255);

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<AssurancesPersonne>(entity =>
            {
                //entity.HasIndex(e => e.FicheId);

                entity.Property(e => e.Autre).HasMaxLength(255);

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            //modelBuilder.Entity<Concernes>(entity =>
            //{
            //    entity.HasIndex(e => e.FicheId);
            //});

            modelBuilder.Entity<ContratsPortefeuilles>(entity =>
            {
                entity.HasIndex(e => e.FicheId);

                entity.Property(e => e.Autre).HasMaxLength(255);

                entity.Property(e => e.CotisationAnnuelle).HasMaxLength(255);

                entity.Property(e => e.DateSouscription).HasColumnType("date");

                entity.Property(e => e.Garantie).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.HasOne(d => d.Fiche)
                    .WithMany(p => p.ContratsPortefeuilles)
                    .HasForeignKey(d => d.FicheId);
            });

            modelBuilder.Entity<DescriptionsActivite>(entity =>
            {
                entity.HasIndex(e => e.FicheId);

                //entity.Property(e => e.ContactFaceAface)
                //    .HasColumnName("ContactFaceAFace")
                //    .HasColumnType("text");

                entity.Property(e => e.ContactFonction).HasColumnType("text");

                entity.Property(e => e.ContactOrigine).HasColumnType("text");

                entity.Property(e => e.ContactRole).HasColumnType("text");

                //entity.Property(e => e.ContactTelephone).HasColumnType("text");

                entity.Property(e => e.EntretienDeroulement).HasColumnType("text");

                entity.Property(e => e.EntretienObjectifs).HasColumnType("text");

                entity.HasOne(d => d.Fiche)
                    .WithMany(p => p.DescriptionsActivite)
                    .HasForeignKey(d => d.FicheId);
            });

            modelBuilder.Entity<Fiches>(entity =>
            {
                entity.HasIndex(e => e.StudentId)
                    .HasName("IX_Fiches_student_id");

                entity.HasOne(d => d.ActiviteType)
                    .WithMany(p => p.Fiches)
                    .HasForeignKey(d => d.ActiviteTypeId)
                    .HasConstraintName("FK_Fiches_ActiviteTypes1");

                entity.HasOne(d => d.Activites)
                    .WithMany(p => p.Fiches)
                    .HasForeignKey(d => d.ActivitesId)
                    .HasConstraintName("FK_Fiches_Activites");

                entity.HasOne(d => d.Concernes)
                    .WithMany(p => p.Fiches)
                    .HasForeignKey(d => d.ConcernesId)
                    .HasConstraintName("FK_Fiches_Concernes");
            });

            modelBuilder.Entity<FichesClientProspect>(entity =>
            {
                entity.HasIndex(e => e.FicheId);

                entity.Property(e => e.Adresse).HasMaxLength(255);

                entity.Property(e => e.AgesEnfants).HasMaxLength(150);

                entity.Property(e => e.Anciennete).HasMaxLength(150);

                entity.Property(e => e.Autre).HasMaxLength(255);

                entity.Property(e => e.CodePostal).HasMaxLength(10);

                entity.Property(e => e.Mail).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.NbEnfants).HasMaxLength(150);

                entity.Property(e => e.Nom).HasMaxLength(100);

                entity.Property(e => e.Placements).HasMaxLength(150);

                entity.Property(e => e.Prenom).HasMaxLength(100);

                entity.Property(e => e.Revenus).HasMaxLength(150);

                entity.Property(e => e.Sexe).HasMaxLength(10);

                entity.Property(e => e.SituationFamiliale).HasMaxLength(255);

                entity.Property(e => e.SituationProfessionnelle).HasMaxLength(255);

                entity.Property(e => e.Statut).HasMaxLength(150);

                entity.Property(e => e.TauxImposition).HasMaxLength(150);

                entity.Property(e => e.Telephone).HasMaxLength(20);

                entity.Property(e => e.Ville).HasMaxLength(100);

                entity.HasOne(d => d.Fiche)
                    .WithMany(p => p.FichesClientProspect)
                    .HasForeignKey(d => d.FicheId);
            });

            modelBuilder.Entity<FichesContexteSimplifiee>(entity =>
            {
                entity.HasIndex(e => e.FicheId);

                entity.Property(e => e.ActionsCommerciales).HasColumnType("text");

                entity.Property(e => e.ActivitesEntreprise).HasColumnType("text");

                entity.Property(e => e.Cible).HasColumnType("text");

                entity.Property(e => e.CompagnieMandante).HasMaxLength(150);

                entity.Property(e => e.EntrepriseNom).HasMaxLength(150);

                entity.Property(e => e.Historique).HasColumnType("text");

                entity.Property(e => e.PresentationPortefeuilleClients).HasColumnType("text");

                entity.Property(e => e.ReductionsAutre).HasColumnType("text");

                entity.Property(e => e.ReductionsMontant).HasColumnType("text");

                entity.Property(e => e.ReductionsNature).HasColumnType("text");

                entity.Property(e => e.ReductionsPeriode).HasColumnType("text");

                entity.HasOne(d => d.Fiche)
                    .WithMany(p => p.FichesContexteSimplifiee)
                    .HasForeignKey(d => d.FicheId);
            });

            modelBuilder.Entity<FichesFin>(entity =>
            {
                entity.HasIndex(e => e.FicheId);

                entity.Property(e => e.AutoEvaluation).HasColumnType("text");

                entity.Property(e => e.InformationsAconserver)
                    .HasColumnName("InformationsAConserver")
                    .HasColumnType("text");

                entity.Property(e => e.PlanificationActions).HasColumnType("text");

                entity.HasOne(d => d.Fiche)
                    .WithMany(p => p.FichesFin)
                    .HasForeignKey(d => d.FicheId);
            });

            modelBuilder.Entity<Phases>(entity =>
            {
                entity.HasIndex(e => e.FicheId);

                entity.Property(e => e.PhaseAsseoirVente).HasColumnType("text");

                entity.Property(e => e.PhaseConclusion).HasColumnType("text");

                entity.Property(e => e.PhaseContact).HasColumnType("text");

                entity.Property(e => e.PhaseDecouverte).HasColumnType("text");

                entity.Property(e => e.PhasePriseConge).HasColumnType("text");

                entity.Property(e => e.PhaseTransition).HasColumnType("text");

                entity.Property(e => e.PhaseVente).HasColumnType("text");

                entity.HasOne(d => d.Fiche)
                    .WithMany(p => p.Phases)
                    .HasForeignKey(d => d.FicheId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
