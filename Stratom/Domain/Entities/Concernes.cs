using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public partial class Concernes
    {
        public Concernes()
        {
            Fiches = new HashSet<Fiches>();
        }

        public int Id { get; set; }
        //public int FicheId { get; set; }
        public string Libelle { get; set; }

        public virtual ICollection<Fiches> Fiches { get; set; }
    }
}
