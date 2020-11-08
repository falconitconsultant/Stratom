﻿using Microsoft.EntityFrameworkCore;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Data.Repositories
{
    public class ActiviteRepository : Repository<Activite>, IActiviteRepository
    {
        public ActiviteRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<Activite>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.Activites.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<Activite> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.Activites.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Activite>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.Activites.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
    }
}