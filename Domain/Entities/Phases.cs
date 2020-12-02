using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Phases
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public string PhaseContact { get; set; }
        public string PhaseDecouverte { get; set; }
        public string PhaseTransition { get; set; }
        public string PhaseVente { get; set; }
        public string PhaseConclusion { get; set; }
        public string PhaseAsseoirVente { get; set; }
        public string PhasePriseConge { get; set; }

        public virtual Fiches Fiche { get; set; }
    }
}
