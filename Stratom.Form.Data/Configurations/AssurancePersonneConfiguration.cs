using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class AssurancePersonneConfiguration : IEntityTypeConfiguration<AssurancePersonne>
    {
        public void Configure(EntityTypeBuilder<AssurancePersonne> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Libelle)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(m => m.Autre)                
                .HasMaxLength(255);

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.AssurancesPersonne)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("AssurancesPersonne");
        }
    }
}
