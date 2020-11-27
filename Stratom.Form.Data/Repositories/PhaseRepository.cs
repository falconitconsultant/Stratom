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
    public class PhaseRepository : Repository<Phase>, IPhaseRepository
    {
        public PhaseRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<Phase>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.Phases.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<Phase> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.Phases.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<Phase>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.Phases.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
        public void Update(Phase phase)
        {
            var objFromDb = StratomFormDbContext.Phases.FirstOrDefault(c => c.Id == phase.Id);
            objFromDb.PhaseContact = phase.PhaseContact;
            objFromDb.PhaseDecouverte = phase.PhaseDecouverte;
            objFromDb.PhaseTransition = phase.PhaseTransition;
            objFromDb.PhaseVente = phase.PhaseVente;
            objFromDb.PhaseConclusion = phase.PhaseConclusion;
            objFromDb.PhaseAsseoirVente = phase.PhaseAsseoirVente;
            objFromDb.PhasePriseConge = phase.PhasePriseConge;
            StratomFormDbContext.SaveChanges();
        }
    }
}
