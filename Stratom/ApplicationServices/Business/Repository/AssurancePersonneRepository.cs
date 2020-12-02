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
    public class AssurancePersonneRepository : Repository<AssurancesPersonne>, IAssurancePersonneRepository
    {
        public AssurancePersonneRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        //public async Task<IEnumerable<AssurancePersonne>> GetAllWithFichesAsync()
        //{
        //    return await StratomContext.AssurancesPersonne.Include(m => m.Fiche).ToListAsync();
        //}

        //public async Task<AssurancePersonne> GetWithFichesByIdAsync(int id)
        //{
        //    return await StratomContext.AssurancesPersonne.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        //}

        //public async Task<IEnumerable<AssurancePersonne>> GetAllWithFicheByFicheIdAsync(int ficheId)
        //{
        //    return await StratomContext.AssurancesPersonne.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        //}

        public void Update(AssurancesPersonne assurancePersonne)
        {
            var objFromDb = StratomContext.AssurancesPersonne.FirstOrDefault(c => c.Id == assurancePersonne.Id);
            objFromDb.Libelle = assurancePersonne.Libelle;
            objFromDb.Autre = assurancePersonne.Autre;
            StratomContext.SaveChanges();
        }
    }
}
