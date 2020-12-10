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
    public class PhaseRepository : Repository<Phases>, IPhaseRepository
    {
        public PhaseRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        public async Task<IEnumerable<Phases>> GetAllWithFichesAsync()
        {
            return await StratomContext.Phases.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<Phases> GetWithFichesByIdAsync(int id)
        {
            return await StratomContext.Phases.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.FicheId == id);
        }

        public async Task<IEnumerable<Phases>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomContext.Phases.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }
        public void Update(Phases phase)
        {
            var objFromDb = StratomContext.Phases.FirstOrDefault(c => c.Id == phase.Id);
            objFromDb.PhaseContact = phase.PhaseContact;
            objFromDb.PhaseDecouverte = phase.PhaseDecouverte;
            objFromDb.PhaseTransition = phase.PhaseTransition;
            objFromDb.PhaseVente = phase.PhaseVente;
            objFromDb.PhaseConclusion = phase.PhaseConclusion;
            objFromDb.PhaseAsseoirVente = phase.PhaseAsseoirVente;
            objFromDb.PhasePriseConge = phase.PhasePriseConge;
            StratomContext.SaveChanges();
        }

        public void Add(Phases phase)
        {
            StratomContext.Phases.Add(phase);
            StratomContext.SaveChanges();
        }
    }
}
