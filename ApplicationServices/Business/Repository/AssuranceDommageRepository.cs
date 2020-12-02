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
    public class AssuranceDommageRepository : Repository<AssurancesDommage>, IAssuranceDommageRepository
    {
        public AssuranceDommageRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        //public async Task<IEnumerable<AssuranceDommage>> GetAllWithFicheByFicheIdAsync(int ficheId)
        //{
        //    return await StratomContext.AssurancesDommage.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        //}

        //public async Task<IEnumerable<AssuranceDommage>> GetAllWithFichesAsync()
        //{
        //    return await StratomContext.AssurancesDommage.Include(m => m.Fiche).ToListAsync();
        //}

        //public async Task<AssuranceDommage> GetWithFichesByIdAsync(int id)
        //{
        //    return await StratomContext.AssurancesDommage.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        //}

        public void Update(AssurancesDommage assuranceDommage)
        {
            var objFromDb = StratomContext.AssurancesDommage.FirstOrDefault(c => c.Id == assuranceDommage.Id);
            objFromDb.Libelle = assuranceDommage.Libelle;
            objFromDb.Autre = assuranceDommage.Autre;
            StratomContext.SaveChanges();
        }
    }
}
