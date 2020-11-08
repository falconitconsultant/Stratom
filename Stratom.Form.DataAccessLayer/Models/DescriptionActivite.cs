using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("DescriptionActivite")]
    public class DescriptionActivite
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

        [Column(TypeName = "text")]
        public string ContactOrigine { get; set; }

        [Column(TypeName = "text")]
        public string ContactFaceAface { get; set; }

        [Column(TypeName = "text")]
        public string ContactTelephone { get; set; }

        [Column(TypeName = "text")]
        public string ContactRole { get; set; }

        [Column(TypeName = "text")]
        public string ContactFonction { get; set; }

        [Column(TypeName = "text")]
        public string EntretienObjectifs { get; set; }

        [Column(TypeName = "text")]
        public string EntretienDeroulement { get; set; }
    }
}
