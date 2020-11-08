using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class FicheClientProspectConfiguration : IEntityTypeConfiguration<FicheClientProspect>
    {
        public void Configure(EntityTypeBuilder<FicheClientProspect> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Nom)
                .HasMaxLength(100);

            builder
                .Property(m => m.Prenom)
                .HasMaxLength(100);

            builder
                .Property(m => m.Sexe)
                .HasMaxLength(10);

            builder
                .Property(m => m.Age)
                .HasColumnType("int");

            builder
                .Property(m => m.Adresse)
                .HasMaxLength(255);

            builder
                .Property(m => m.CodePostal)
                .HasMaxLength(10);

            builder
                .Property(m => m.Ville)
                .HasMaxLength(100);

            builder
                .Property(m => m.Telephone)
                .HasMaxLength(20);

            builder
                .Property(m => m.Mobile)
                .HasMaxLength(20);

            builder
                .Property(m => m.Mail)
                .HasMaxLength(50);

            builder
                .Property(m => m.Autre)
                .HasMaxLength(255);

            builder
                .Property(m => m.SituationFamiliale)
                .HasMaxLength(255);

            builder
                .Property(m => m.NbEnfants)
                .HasMaxLength(150);

            builder
                .Property(m => m.AgesEnfants)
                .HasMaxLength(150);

            builder
                .Property(m => m.SituationProfessionnelle)
                .HasMaxLength(255);

            builder
                .Property(m => m.IsClient)
                .IsRequired()
                .HasColumnType("bit");

            builder
                .Property(m => m.Statut)
                .HasMaxLength(150);

            builder
                .Property(m => m.Anciennete)
                .HasMaxLength(150);

            builder
                .Property(m => m.Revenus)
                .HasMaxLength(150);

            builder
                .Property(m => m.TauxImposition)
                .HasMaxLength(150);

            builder
                .Property(m => m.Placements)
                .HasMaxLength(150);

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.FichesClientProspect)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("FichesClientProspect");
        }
    }
}
