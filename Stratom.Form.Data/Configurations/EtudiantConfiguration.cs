using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class EtudiantConfiguration : IEntityTypeConfiguration<Etudiant>
    {
        public void Configure(EntityTypeBuilder<Etudiant> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Nom)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(m => m.Prenom)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.Etudiants)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("Etudiants");
        }
    }
}
