using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class DescriptionActiviteConfiguration : IEntityTypeConfiguration<DescriptionActivite>
    {
        public void Configure(EntityTypeBuilder<DescriptionActivite> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.ContactOrigine)                
                .HasColumnType("Text");

            builder
                .Property(m => m.ContactFaceAFace)                
                .HasColumnType("Text");

            builder
                .Property(m => m.ContactTelephone)                
                .HasColumnType("Text");

            builder
                .Property(m => m.ContactRole)                
                .HasColumnType("Text");

            builder
                .Property(m => m.ContactFonction)                
                .HasColumnType("Text");

            builder
                .Property(m => m.EntretienObjectifs)                
                .HasColumnType("Text");

            builder
                .Property(m => m.EntretienDeroulement)                
                .HasColumnType("Text");

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.DescriptionsActivite)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("DescriptionsActivite");
        }
    }
}
