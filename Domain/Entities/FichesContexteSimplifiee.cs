using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class FichesContexteSimplifiee
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public string EntrepriseNom { get; set; }
        public string CompagnieMandante { get; set; }
        public string Historique { get; set; }
        public string PresentationPortefeuilleClients { get; set; }
        public string ActivitesEntreprise { get; set; }
        public string Cible { get; set; }
        public string ActionsCommerciales { get; set; }
        public string ReductionsNature { get; set; }
        public string ReductionsMontant { get; set; }
        public string ReductionsPeriode { get; set; }
        public string ReductionsAutre { get; set; }

        public virtual Fiches Fiche { get; set; }
    }
}
