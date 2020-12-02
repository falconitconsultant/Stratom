using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class FichesClientProspect
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public int Age { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public string Autre { get; set; }
        public string SituationFamiliale { get; set; }
        public string NbEnfants { get; set; }
        public string AgesEnfants { get; set; }
        public string SituationProfessionnelle { get; set; }
        public bool IsClient { get; set; }
        public string Statut { get; set; }
        public string Anciennete { get; set; }
        public string Revenus { get; set; }
        public string TauxImposition { get; set; }
        public string Placements { get; set; }

        public virtual Fiches Fiche { get; set; }
    }
}
