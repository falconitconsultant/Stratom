using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Stratom.Form.Core.Models;

namespace Stratom.Form.Data.Configurations
{
    public class ActiviteTypeConfiguration : IEntityTypeConfiguration<ActiviteType>
    {
        public void Configure(EntityTypeBuilder<ActiviteType> builder)
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
                .HasOne(m => m.Fiche)
                .WithMany(a => a.ActiviteTypes)
                .HasForeignKey(m => m.FicheId);

            builder
                .ToTable("ActiviteTypes");
        }
    }
}
