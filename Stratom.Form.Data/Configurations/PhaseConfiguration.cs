using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class PhaseConfiguration : IEntityTypeConfiguration<Phase>
    {
        public void Configure(EntityTypeBuilder<Phase> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.PhaseContact)                
                .HasColumnType("Text");

            builder
                .Property(m => m.PhaseDecouverte)               
                .HasColumnType("Text");

            builder
                .Property(m => m.PhaseTransition)                
                .HasColumnType("Text");

            builder
                .Property(m => m.PhaseVente)                
                .HasColumnType("Text");

            builder
                .Property(m => m.PhaseConclusion)                
                .HasColumnType("Text");

            builder
                .Property(m => m.PhaseAsseoirVente)                
                .HasColumnType("Text");

            builder
                .Property(m => m.PhasePriseConge)                
                .HasColumnType("Text");

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.Phases)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("Phases");
        }
    }
}
