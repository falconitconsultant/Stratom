using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("Activite")]
    public class Activite
    {
        // Primary Key
        [Key]
        // Auto increament
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }

        [Required] //Titre/nature de l’activité : Souscription : Auto du particulier / Auto du pro / MRH / MRP / Gav /Santé du particulier/ Santé collective/Prévoyance décès/ Prévoyance collective/ Assurance vie / Retraite/Epargne bancaire/ Autre 
        public string Souscription { get; set; }

        public string Autre { get; set; }
    }
}
