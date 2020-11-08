using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("Phases")]
    public class Phases
    {
        [Key]
        // Auto increament
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }

        [Required]
        public int NumeroFiche { get; set; }

        [Column(TypeName = "text")]
        public string PhaseContact { get; set; }

        [Column(TypeName = "text")]
        public string PhaseDecouverte { get; set; }

        [Column(TypeName = "text")]
        public string PhaseTransition { get; set; }

        [Column(TypeName = "text")]
        public string PhaseVente { get; set; }

        [Column(TypeName = "text")]
        public string PhaseConclusion { get; set; }

        [Column(TypeName = "text")]
        public string PhaseAsseoirVente { get; set; }

        [Column(TypeName = "text")]
        public string PhasePriseConge { get; set; }
    }
}
