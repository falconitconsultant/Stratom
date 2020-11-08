using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class FicheConfiguration : IEntityTypeConfiguration<Fiche>
    {
        public void Configure(EntityTypeBuilder<Fiche> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.NumeroFiche)
                .IsRequired()
                .HasColumnType("int");

            builder
                .ToTable("Fiches");
        }
    }
}
