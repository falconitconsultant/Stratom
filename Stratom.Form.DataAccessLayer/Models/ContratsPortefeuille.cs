using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("ContratsPortefeuille")]
    public class ContratsPortefeuille
    {
        [Key]
        // Auto increament
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }

        public string Type { get; set; }

        public string Garantie { get; set; }

        public string DateSouscription { get; set; }

        public string CotisationAnnuelle { get; set; }

        [Column(TypeName = "text")]
        public string Autre { get; set; }
    }
}
