using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public partial class Fiches
    {
        public Fiches()
        {
            ContratsPortefeuilles = new HashSet<ContratsPortefeuilles>();
            DescriptionsActivite = new HashSet<DescriptionsActivite>();
            FichesClientProspect = new HashSet<FichesClientProspect>();
            FichesContexteSimplifiee = new HashSet<FichesContexteSimplifiee>();
            FichesFin = new HashSet<FichesFin>();
            Phases = new HashSet<Phases>();
        }

        public int Id { get; set; }
        public int NumeroFiche { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int? ActiviteTypeId { get; set; }
        public string StudentId { get; set; }
        public int? ConcernesId { get; set; }
        public int? ActivitesId { get; set; }

        [ForeignKey("StudentId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ActiviteTypes ActiviteType { get; set; }
        public virtual Activites Activites { get; set; }
        public virtual Concernes Concernes { get; set; }
        public virtual ICollection<ContratsPortefeuilles> ContratsPortefeuilles { get; set; }
        public virtual ICollection<DescriptionsActivite> DescriptionsActivite { get; set; }
        public virtual ICollection<FichesClientProspect> FichesClientProspect { get; set; }
        public virtual ICollection<FichesContexteSimplifiee> FichesContexteSimplifiee { get; set; }
        public virtual ICollection<FichesFin> FichesFin { get; set; }
        public virtual ICollection<Phases> Phases { get; set; }
    }
}
