using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("FicheFin")]
    public class FicheFin
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
        public string InformationsAConserver { get; set; }

        [Column(TypeName = "text")]
        public string PlanificationActions { get; set; }

        [Column(TypeName = "text")]
        public string AutoEvaluation  { get; set; }
    }
}
