using Stratom.Form.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stratom.Form.BusinessLayer.Services
{
    public class FicheService
    {
        private readonly StratomDbContext _context;
        public FicheService(StratomDbContext context)
        {
            _context = context;
        }
    }
}
