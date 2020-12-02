using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class ContratsPortefeuilles
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public string Type { get; set; }
        public string Garantie { get; set; }
        public DateTime DateSouscription { get; set; }
        public string CotisationAnnuelle { get; set; }
        public string Autre { get; set; }

        public virtual Fiches Fiche { get; set; }
    }
}
