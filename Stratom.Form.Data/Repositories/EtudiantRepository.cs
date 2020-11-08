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
    public class EtudiantRepository : Repository<Etudiant>, IEtudiantRepository
    {
        public EtudiantRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<Etudiant>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.Etudiants.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<Etudiant> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.Etudiants.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Etudiant>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.Etudiants.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
    }
}
