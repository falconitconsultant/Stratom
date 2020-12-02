using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class AssurancesDommage
    {
        public AssurancesDommage()
        {
            Activites = new HashSet<Activites>();
        }

        public int Id { get; set; }
        //public int FicheId { get; set; }
        public string Libelle { get; set; }
        public string Autre { get; set; }

        public virtual ICollection<Activites> Activites { get; set; }
    }
}
