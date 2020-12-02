using Domain.Entities;
using Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices.Business.AppServices.IAppServices;

namespace ApplicationServices.Business.AppServices
{
    public class FicheFinRepository : Repository<FichesFin>, IFicheFinRepository
    {
        public FicheFinRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        public async Task<IEnumerable<FichesFin>> GetAllWithFichesAsync()
        {
            return await StratomContext.FichesFin.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<FichesFin> GetWithFichesByIdAsync(int id)
        {
            return await StratomContext.FichesFin.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<FichesFin>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomContext.FichesFin.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
        public void Update(FichesFin ficheFin)
        {
            var objFromDb = StratomContext.FichesFin.FirstOrDefault(c => c.Id == ficheFin.Id);
            objFromDb.InformationsAconserver = ficheFin.InformationsAconserver;
            objFromDb.PlanificationActions = ficheFin.PlanificationActions;
            objFromDb.AutoEvaluation = ficheFin.AutoEvaluation;
            StratomContext.SaveChanges();
        }
    }
}
