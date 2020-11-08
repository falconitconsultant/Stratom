using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("AssuranceDommage")]
    public class AssuranceDommage
    {
        //Assurance de Dommages :         Automobile  	MRH  	MRPro   	Autre    (précisez) : 
        [Key]
        // Auto increament
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }

        [Required]
        public string Libelle { get; set; }

        public string Autre { get; set; }
    }
}
