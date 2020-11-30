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
    public class ContratsPortefeuilleRepository : Repository<ContratsPortefeuille>, IContratsPortefeuilleRepository
    {
        public ContratsPortefeuilleRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<ContratsPortefeuille>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.ContratsPortefeuilles.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<ContratsPortefeuille> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.ContratsPortefeuilles.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<ContratsPortefeuille>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.ContratsPortefeuilles.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
        public void Update(ContratsPortefeuille contratsPortefeuille)
        {
            var objFromDb = StratomFormDbContext.ContratsPortefeuilles.FirstOrDefault(c => c.Id == contratsPortefeuille.Id);
            objFromDb.Type = contratsPortefeuille.Type;
            objFromDb.Garantie = contratsPortefeuille.Garantie;
            objFromDb.DateSouscription = contratsPortefeuille.DateSouscription;
            objFromDb.CotisationAnnuelle = contratsPortefeuille.CotisationAnnuelle;
            objFromDb.Autre = contratsPortefeuille.Autre;
            StratomFormDbContext.SaveChanges();
        }
    }
}
