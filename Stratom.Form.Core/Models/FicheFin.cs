using System;
using System.Collections.Generic;
using System.Text;

namespace Stratom.Form.Core.Models
{
    public class FicheFin
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }
        public string InformationsAConserver { get; set; }
        public string PlanificationActions { get; set; }
        public string AutoEvaluation  { get; set; }
    }
}
