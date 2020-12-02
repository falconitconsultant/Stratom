using ApplicationServices.Business.AppServices.IAppServices;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices
{
    public class ActiviteRepository : Repository<Activites>, IActiviteRepository
    {
        public ActiviteRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        //public async Task<IEnumerable<Activite>> GetAllWithFichesAsync()
        //{
        //    return await StratomContext.Activites.Include(m => m.Fiche).ToListAsync();
        //}

        //public async Task<Activite> GetWithFichesByIdAsync(int id)
        //{
        //    return await StratomContext.Activites.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        //}

        //public async Task<IEnumerable<Activite>> GetAllWithFicheByFicheIdAsync(int ficheId)
        //{
        //    return await StratomContext.Activites.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        //}

        void IActiviteRepository.Update(Activites activite)
        {
            var objFromDb = StratomContext.Activites.FirstOrDefault(c => c.Id == activite.Id);
            objFromDb.Souscription = activite.Souscription;
            objFromDb.Autre = activite.Autre;
            StratomContext.SaveChanges();
            
        }
    }
}
