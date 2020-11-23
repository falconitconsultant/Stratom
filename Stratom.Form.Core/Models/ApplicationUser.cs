﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Stratom.Form.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int FicheId { get; set; }
        [ForeignKey("FicheId")]
        public Fiche Fiche { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
    }
}