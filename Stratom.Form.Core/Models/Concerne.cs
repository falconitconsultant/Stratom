﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Stratom.Form.Core.Models
{
    public class Concerne
    {
        public int Id { get; set; }
        public int FicheId { get; set; }
        public Fiche Fiche { get; set; }
        public string Libelle { get; set; }
    }
}
