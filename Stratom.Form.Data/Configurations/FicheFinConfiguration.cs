using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class FicheFinConfiguration : IEntityTypeConfiguration<FicheFin>
    {
        public void Configure(EntityTypeBuilder<FicheFin> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.InformationsAConserver)                
                .HasColumnType("Text");

            builder
                .Property(m => m.PlanificationActions)                
                .HasColumnType("Text");

            builder
                .Property(m => m.AutoEvaluation)
                .HasColumnType("Text");

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.FichesFin)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("FichesFin");
        }
    }
}
