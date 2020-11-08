using System;
using System.Collections.Generic;
using System.Text;

namespace Stratom.Form.Core.Models
{
    public class DescriptionActivite
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }    
        public string ContactOrigine { get; set; }
        public string ContactFaceAFace { get; set; }
        public string ContactTelephone { get; set; }
        public string ContactRole { get; set; }        
        public string ContactFonction { get; set; }        
        public string EntretienObjectifs { get; set; }
        public string EntretienDeroulement { get; set; }
    }
}
