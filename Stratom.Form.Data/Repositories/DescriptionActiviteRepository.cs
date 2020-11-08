﻿using Microsoft.EntityFrameworkCore;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Data.Repositories
{
    public class DescriptionActiviteRepository : Repository<DescriptionActivite>, IDescriptionActiviteRepository
    {
        public DescriptionActiviteRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<DescriptionActivite>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.DescriptionsActivite.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<DescriptionActivite> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.DescriptionsActivite.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<DescriptionActivite>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.DescriptionsActivite.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
    }
}
