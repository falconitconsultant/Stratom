using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stratom.Form.Core.Models
{    
    public class Fiche
    {
        public Fiche()
        {
            Activites                   = new Collection<Activite>();
            ActiviteTypes               = new Collection<ActiviteType>();
            Concernes                   = new Collection<Concerne>();
            AssurancesPersonne          = new Collection<AssurancePersonne>();
            AssurancesDommage           = new Collection<AssuranceDommage>();
            FichesClientProspect        = new Collection<FicheClientProspect>();
            DescriptionsActivite        = new Collection<DescriptionActivite>();
            FichesContexteSimplifiee    = new Collection<FicheContexteSimplifiee>();
            ContratsPortefeuilles       = new Collection<ContratsPortefeuille>();
            Phases                      = new Collection<Phase>();
            FichesFin                   = new Collection<FicheFin>();
        }

        public int Id { get; set; }
        public int NumeroFiche { get; set; }
        public string student_id { get; set; }
        [ForeignKey("student_id")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<ActiviteType> ActiviteTypes { get; set; }                
        public virtual ICollection<Concerne> Concernes { get; set; }       
        public virtual ICollection<Activite> Activites { get; set; }        
        public virtual ICollection<AssurancePersonne> AssurancesPersonne { get; set; }                  
        public virtual ICollection<AssuranceDommage> AssurancesDommage { get; set; }       
        public virtual ICollection<FicheClientProspect> FichesClientProspect { get; set; }              
        public virtual ICollection<DescriptionActivite> DescriptionsActivite { get; set; }
        public virtual ICollection<FicheContexteSimplifiee> FichesContexteSimplifiee { get; set; }
        public virtual ICollection<ContratsPortefeuille> ContratsPortefeuilles { get; set; }
        public virtual ICollection<Phase> Phases { get; set; }        
        public virtual ICollection<FicheFin> FichesFin { get; set; }
    }
}
