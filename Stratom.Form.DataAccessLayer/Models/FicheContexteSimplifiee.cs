using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stratom.Form.DataAccessLayer.Models
{
    [Table("FicheContexteSimplifiee")]
    public class FicheContexteSimplifiee
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

        public string EntrepriseNom  { get; set; }

        public string CompagnieMandante { get; set; }

        [Column(TypeName = "text")]
        public string Historique { get; set; }

        [Column(TypeName = "text")]
        public string PresentationPortefeuilleClients { get; set; }

        [Column(TypeName = "text")]
        public string ActivitesEntreprise { get; set; }

        [Column(TypeName = "text")]
        public string Cible { get; set; }

        [Column(TypeName = "text")]
        public string ActionsCommerciales { get; set; }

        [Column(TypeName = "text")]
        public string ReductionsNature { get; set; }

        [Column(TypeName = "text")]
        public string ReductionsMontant { get; set; }

        [Column(TypeName = "text")]
        public string ReductionsPeriode { get; set; }

        [Column(TypeName = "text")]
        public string ReductionsAutre { get; set; }
    }
}
