using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class DescriptionsActivite
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public string ContactOrigine { get; set; }
        public string ContactFaceAface { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactRole { get; set; }
        public string ContactFonction { get; set; }
        public string EntretienObjectifs { get; set; }
        public string EntretienDeroulement { get; set; }

        public virtual Fiches Fiche { get; set; }
    }
}
