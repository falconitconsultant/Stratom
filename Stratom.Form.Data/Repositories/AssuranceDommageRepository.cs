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
    public class AssuranceDommageRepository : Repository<AssuranceDommage>, IAssuranceDommageRepository
    {
        public AssuranceDommageRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<AssuranceDommage>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.AssurancesDommage.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }

        public async Task<IEnumerable<AssuranceDommage>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.AssurancesDommage.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<AssuranceDommage> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.AssurancesDommage.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}
