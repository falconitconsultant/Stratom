using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Stratom.Form.Core.Models;
using Stratom.Form.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stratom.Form.Data
{
    public class StratomFormDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Fiche> Fiches { get; set; }
        public DbSet<Activite> Activites { get; set; }
        public DbSet<ActiviteType> ActiviteTypes { get; set; }
        public DbSet<AssuranceDommage> AssurancesDommage { get; set; }
        public DbSet<AssurancePersonne> AssurancesPersonne { get; set; }
        public DbSet<Concerne> Concernes { get; set; }
        public DbSet<ContratsPortefeuille> ContratsPortefeuilles { get; set; }
        public DbSet<DescriptionActivite> DescriptionsActivite { get; set; }
        public DbSet<FicheClientProspect> FichesClientProspect { get; set; }
        public DbSet<FicheContexteSimplifiee> FichesContexteSimplifiee { get; set; }
        public DbSet<FicheFin> FichesFin { get; set; }
        public DbSet<Phase> Phases { get; set; }

        public StratomFormDbContext(DbContextOptions<StratomFormDbContext> options)
            : base(options)
        { }
        public StratomFormDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ActiviteConfiguration());
            builder.ApplyConfiguration(new AssuranceDommageConfiguration());
            builder.ApplyConfiguration(new AssurancePersonneConfiguration());
            builder.ApplyConfiguration(new ContratsPortefeuilleConfiguration());
            builder.ApplyConfiguration(new DescriptionActiviteConfiguration());
            builder.ApplyConfiguration(new FicheClientProspectConfiguration());
            builder.ApplyConfiguration(new FicheContexteSimplifieeConfiguration());
            builder.ApplyConfiguration(new FicheFinConfiguration()); 
            builder.ApplyConfiguration(new PhaseConfiguration());
            builder.ApplyConfiguration(new FicheConfiguration());
        }
    }
}
