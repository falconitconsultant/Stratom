using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class FicheContexteSimplifieeConfiguration : IEntityTypeConfiguration<FicheContexteSimplifiee>
    {
        public void Configure(EntityTypeBuilder<FicheContexteSimplifiee> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.EntrepriseNom)                
                .HasMaxLength(150);

            builder
                .Property(m => m.CompagnieMandante)                
                .HasMaxLength(150);

            builder
                .Property(m => m.Historique)                
                .HasColumnType("Text");

            builder
                .Property(m => m.PresentationPortefeuilleClients)                
                .HasColumnType("Text");

            builder
                .Property(m => m.ActivitesEntreprise)                
                .HasColumnType("Text");

            builder
                .Property(m => m.Cible)                
                .HasColumnType("Text");

            builder
                .Property(m => m.ActionsCommerciales)
                .HasColumnType("Text");

            builder
                .Property(m => m.ReductionsNature)
                .HasColumnType("Text");

            builder
                .Property(m => m.ReductionsMontant)
                .HasColumnType("Text");

            builder
                .Property(m => m.ReductionsPeriode)
                .HasColumnType("Text");

            builder
                .Property(m => m.ReductionsAutre)
                .HasColumnType("Text");

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.FichesContexteSimplifiee)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("FichesContexteSimplifiee");
        }
    }
}
