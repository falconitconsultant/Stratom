using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Activites
    {
        public Activites()
        {
            Fiches = new HashSet<Fiches>();
        }

        public int Id { get; set; }
        //public int FicheId { get; set; }
        public string Souscription { get; set; }
        public int? AssurancesPersonneId { get; set; }
        public string Autre { get; set; }
        public int? AssurancesDommageId { get; set; }

        public virtual AssurancesDommage AssurancesDommageNavigation { get; set; }
        public virtual AssurancesPersonne AssurancesPersonne { get; set; }
        public virtual ICollection<Fiches> Fiches { get; set; }
    }
}
