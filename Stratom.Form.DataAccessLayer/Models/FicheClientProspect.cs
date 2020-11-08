using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("FicheClientProspect")]
    public class FicheClientProspect
    {
        [Key]
        // Auto increament
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //Foreign key for Fiche
        [Required]
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }

        [Required]
        public int NumeroFiche { get; set; }

        public string Nom { get; set; }
        
        public string Prenom { get; set; }
        
        public string Sexe { get; set; }
        
        public string Age { get; set; }
        
        public string Adresse { get; set; }
        
        public string CodePostal { get; set; }
        
        public string Ville { get; set; }
        
        public string Telephone { get; set; }
        
        public string Mobile { get; set; }
        
        public string Mail { get; set; }

        [Column(TypeName = "text")]
        public string Autre { get; set; }
        
        public string SituationFamiliale { get; set; }

        public string NbEnfants { get; set; }

        public string AgesEnfants { get; set; }

        [Column(TypeName = "text")]
        public string SituationProfessionnelle { get; set; }

        public bool IsClient { get; set; }

        public string Statut { get; set; }

        public string Anciennete { get; set; }

        [ForeignKey("ContratsPortefeuille")]
        public int ContratsPortefeuilleId { get; set; }
        
        public int Revenus { get; set; }

        public int TauxImposition { get; set; }

        [Column(TypeName = "text")]
        public string Placements { get; set; }
    }
}
