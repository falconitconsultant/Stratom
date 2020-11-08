using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class ActiviteConfiguration : IEntityTypeConfiguration<Activite>
    {
        public void Configure(EntityTypeBuilder<Activite> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Souscription)                
                .HasColumnType("Text");

            builder
                .Property(m => m.Autre)
                .HasColumnType("Text");

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.Activites)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("Activites");
        }
    }
}
