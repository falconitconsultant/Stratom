using Microsoft.EntityFrameworkCore;
using Stratom.Form.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stratom.Form.DataAccessLayer
{
    public class StratomDbContext : DbContext
    {
        public DbSet<Fiche> Fiches { get; set; }
        public DbSet<Activite> Activites { get; set; }
        public DbSet<AssuranceDommage> AssurancesDommage { get; set; }
        public DbSet<AssurancePersonne> AssurancesPersonne { get; set; }
        public DbSet<ContratsPortefeuille> ContratsPortefeuilles { get; set; }
        public DbSet<DescriptionActivite> DescriptionsActivite { get; set; }
        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<FicheClientProspect> FichesClientProspect { get; set; }
        public DbSet<FicheContexteSimplifiee> FichesContexteSimplifiee { get; set; }
        public DbSet<FicheFin> FichesFin { get; set; }
        public DbSet<Phases> Phasess { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FALCON-DESKTOP;Database=Stratom;Trusted_Connection=True;");
        }
    }
}
