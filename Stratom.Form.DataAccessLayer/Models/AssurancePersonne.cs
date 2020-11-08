using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("AssurancePersonne")]
    public class AssurancePersonne
    {
        //Assurance de personnes : Complémentaire santé // Prévoyance // GAV // Ass Vie, produit épargne // Autre  (précisez) :
        [Key]
        // Auto increament
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Libelle { get; set; }

        public string Autre { get; set; }
    }
}