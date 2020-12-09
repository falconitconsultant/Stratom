using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModel
{
    public class MainViewModel
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public IEnumerable<Activites> activite { get; set; }
        public IEnumerable<ActiviteTypes> activiteType { get; set; }
        public IEnumerable<AssurancesDommage> assuranceDommage { get; set; }
        public IEnumerable<AssurancesPersonne> assurancePersonne { get; set; }
        public IEnumerable<Concernes> concerne { get; set; }
        public ContratsPortefeuilles contratsPortefeuille { get; set; }
        public DescriptionsActivite descriptionActivite { get; set; }
        public FichesClientProspect ficheClientProspect { get; set; }
        public FichesContexteSimplifiee ficheContexteSimplifiee { get; set; }
        public FichesFin ficheFin { get; set; }
        public Phases phase { get; set; }
        public Fiches fiche { get; set; }
        public string NumberOfDocuments {get;set;}
    }
}
