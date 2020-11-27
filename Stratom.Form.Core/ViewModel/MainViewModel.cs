using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stratom.Form.Core.ViewModel
{
    public class MainViewModel
    {
        public Activite activite { get; set; }
        public ActiviteType activiteType { get; set; }
        public AssuranceDommage assuranceDommage { get; set; }
        public AssurancePersonne assurancePersonne { get; set; }
        public Concerne concerne { get; set; }
        public ContratsPortefeuille contratsPortefeuille { get; set; }
        public DescriptionActivite descriptionActivite { get; set; }
        public FicheClientProspect ficheClientProspect { get; set; }
        public FicheContexteSimplifiee ficheContexteSimplifiee { get; set; }
        public FicheFin ficheFin { get; set; }
        public Phase phase { get; set; }
        public Fiche fiche { get; set; }
    }
}
