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
    public class ConcerneRepository : Repository<Concernes>, IConcerneRepository
    {
        public ConcerneRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        public async Task<IEnumerable<Concernes>> GetAllWithFichesAsync()
        {
            return await StratomContext.Concernes.Include(m => m.Fiches).ToListAsync();
        }

        public async Task<Concernes> GetWithFichesByIdAsync(int id)
        {
            return await StratomContext.Concernes.Include(m => m.Fiches).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Concernes>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomContext.Concernes.Include(m => m.Fiches).ToListAsync();//StratomContext.Concernes.Include(m => m.Fiches).Where(m => m.FicheId == ficheId).ToListAsync();
        }
        public void Update(Concernes concerne)
        {
            var objFromDb = StratomContext.Concernes.FirstOrDefault(c => c.Id == concerne.Id);
            objFromDb.Libelle = concerne.Libelle;
            StratomContext.SaveChanges();
        }
    }
}
