using System;
using System.Collections.Generic;
using System.Text;

namespace Stratom.Form.Core.Models
{    
    public class Phase
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }
        public string PhaseContact { get; set; }
        public string PhaseDecouverte { get; set; }
        public string PhaseTransition { get; set; }
        public string PhaseVente { get; set; }
        public string PhaseConclusion { get; set; }
        public string PhaseAsseoirVente { get; set; }
        public string PhasePriseConge { get; set; }
    }
}
