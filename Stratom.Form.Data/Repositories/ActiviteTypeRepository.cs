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
    public class ActiviteTypeRepository : Repository<ActiviteType>, IActiviteTypeRepository
    {
        public ActiviteTypeRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<ActiviteType>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.ActiviteTypes.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }

        public async Task<IEnumerable<ActiviteType>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.ActiviteTypes.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<ActiviteType> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.ActiviteTypes.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public void Update(ActiviteType activiteType)
        {
            var objFromDb = StratomFormDbContext.ActiviteTypes.FirstOrDefault(c => c.Id == activiteType.Id);
            objFromDb.Libelle = activiteType.Libelle;
            StratomFormDbContext.SaveChanges();
        }

    }
}
