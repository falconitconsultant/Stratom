using System;
using System.Collections.Generic;
using System.Text;

namespace Stratom.Form.Core.Models
{
    public class ContratsPortefeuille
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }
        public string Type { get; set; }
        public string Garantie { get; set; }
        public DateTime DateSouscription { get; set; }
        public string CotisationAnnuelle { get; set; }
        public string Autre { get; set; }
    }
}
