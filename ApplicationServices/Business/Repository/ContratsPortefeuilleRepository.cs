using ApplicationServices.Business.AppServices.IAppServices;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices
{
    public class ContratsPortefeuilleRepository : Repository<ContratsPortefeuilles>, IContratsPortefeuilleRepository
    {
        public ContratsPortefeuilleRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        public async Task<IEnumerable<ContratsPortefeuilles>> GetAllWithFichesAsync()
        {
            return await StratomContext.ContratsPortefeuilles.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<ContratsPortefeuilles> GetWithFichesByIdAsync(int id)
        {
            return await StratomContext.ContratsPortefeuilles.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<ContratsPortefeuilles>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomContext.ContratsPortefeuilles.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
        public void Update(ContratsPortefeuilles contratsPortefeuille)
        {
            var objFromDb = StratomContext.ContratsPortefeuilles.FirstOrDefault(c => c.Id == contratsPortefeuille.Id);
            objFromDb.Type = contratsPortefeuille.Type;
            objFromDb.Garantie = contratsPortefeuille.Garantie;
            objFromDb.DateSouscription = contratsPortefeuille.DateSouscription;
            objFromDb.CotisationAnnuelle = contratsPortefeuille.CotisationAnnuelle;
            objFromDb.Autre = contratsPortefeuille.Autre;
            StratomContext.SaveChanges();
        }
    }
}
