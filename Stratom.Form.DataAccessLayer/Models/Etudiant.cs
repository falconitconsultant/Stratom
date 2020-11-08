using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("Etudiant")]
    public class Etudiant
    {
        // Primary Key
        [Key]
        // Auto increament
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }

        [Required]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }
    }
}
