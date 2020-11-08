﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class ContratsPortefeuilleConfiguration : IEntityTypeConfiguration<ContratsPortefeuille>
    {
        public void Configure(EntityTypeBuilder<ContratsPortefeuille> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Type)                
                .HasMaxLength(100);

            builder
                .Property(m => m.Garantie)                
                .HasMaxLength(255);

            builder
                .Property(m => m.DateSouscription)                
                .HasColumnType("Date");

            builder
                .Property(m => m.CotisationAnnuelle)                
                .HasMaxLength(255);

            builder
                .Property(m => m.Autre)                
                .HasMaxLength(255);

            builder
                .HasOne(m => m.Fiche)
                .WithMany(a => a.ContratsPortefeuilles)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("ContratsPortefeuilles");
        }
    }
}