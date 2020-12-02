using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class FichesFin
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public string InformationsAconserver { get; set; }
        public string PlanificationActions { get; set; }
        public string AutoEvaluation { get; set; }

        public virtual Fiches Fiche { get; set; }
    }
}
