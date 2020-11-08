using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Stratom.Form.Core.Models
{    
    public class Fiche
    {
        public Fiche()
        {
            Etudiants                   = new Collection<Etudiant>();
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
        public ICollection<Etudiant> Etudiants { get; set; }        
        public ICollection<ActiviteType> ActiviteTypes { get; set; }                
        public ICollection<Concerne> Concernes { get; set; }       
        public ICollection<Activite> Activites { get; set; }        
        public ICollection<AssurancePersonne> AssurancesPersonne { get; set; }                  
        public ICollection<AssuranceDommage> AssurancesDommage { get; set; }       
        public ICollection<FicheClientProspect> FichesClientProspect { get; set; }              
        public ICollection<DescriptionActivite> DescriptionsActivite { get; set; }
        public ICollection<FicheContexteSimplifiee> FichesContexteSimplifiee { get; set; }
        public ICollection<ContratsPortefeuille> ContratsPortefeuilles { get; set; }
        public ICollection<Phase> Phases { get; set; }        
        public ICollection<FicheFin> FichesFin { get; set; }
    }
}
