using Microsoft.EntityFrameworkCore;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Data.Repositories
{
    public class FicheFinRepository : Repository<FicheFin>, IFicheFinRepository
    {
        public FicheFinRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<FicheFin>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.FichesFin.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<FicheFin> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.FichesFin.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<FicheFin>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.FichesFin.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
    }
}
