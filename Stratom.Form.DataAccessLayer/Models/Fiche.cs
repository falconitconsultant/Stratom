using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("Fiche")]
    public class Fiche
    {
        // Primary Key
        [Key]
        // Auto increament
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Numero { get; set; }
                
        public ICollection<Etudiant> Etudiant { get; set; }

        [Required] //Activité réelle ou Activité simulée 
        public bool ActiviteType { get; set; }
        
        [Required] //Concerne : un particulier ou un professionnel
        public bool Concerne { get; set; }
       
        public ICollection<Activite> Activite { get; set; }
        
        public ICollection<AssurancePersonne> AssurancesPersonne { get; set; }  
                
        public ICollection<AssuranceDommage> AssurancesDommage { get; set; }
       
        public ICollection<FicheClientProspect> FicheClientProspect { get; set; }
              
        public ICollection<DescriptionActivite> DescriptionActivite { get; set; }

        public ICollection<FicheContexteSimplifiee> FicheContexteSimplifiee { get; set; }

        public ICollection<ContratsPortefeuille> ContratsPortefeuille { get; set; }

        public ICollection<Phases> Phase { get; set; }
        
        public ICollection<FicheFin> FicheFin { get; set; }
    }
}
