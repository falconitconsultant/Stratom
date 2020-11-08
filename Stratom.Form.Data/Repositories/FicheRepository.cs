using Microsoft.EntityFrameworkCore;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Data.Repositories
{
    public class FicheRepository : Repository<Fiche>, IFicheRepository
    {
        public FicheRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<Fiche>> GetAllByEtudiantIdAsync(int etudiantId)
        {
            return await StratomFormDbContext.Fiches
                .Include(m => m.Activites)
                .Include(m => m.ActiviteTypes)
                .Include(m => m.AssurancesDommage)
                .Include(m => m.AssurancesPersonne)
                .Include(m => m.Concernes)
                .Include(m => m.ContratsPortefeuilles)
                .Include(m => m.DescriptionsActivite)
                .Include(m => m.Etudiants.Where(i => i.Id == etudiantId))
                .Include(m => m.FichesClientProspect)
                .Include(m => m.FichesContexteSimplifiee)
                .Include(m => m.FichesFin)
                .Include(m => m.Phases)                
                .ToListAsync();
        }

        public async Task<Fiche> GetAllByIdAsync(int id)
        {
            return await StratomFormDbContext.Fiches
                .Include(m => m.Activites)
                .Include(m => m.ActiviteTypes)
                .Include(m => m.AssurancesDommage)
                .Include(m => m.AssurancesPersonne)
                .Include(m => m.Concernes)
                .Include(m => m.ContratsPortefeuilles)
                .Include(m => m.DescriptionsActivite)
                .Include(m => m.Etudiants)
                .Include(m => m.FichesClientProspect)
                .Include(m => m.FichesContexteSimplifiee)
                .Include(m => m.FichesFin)
                .Include(m => m.Phases)
                .SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<Fiche> GetAllByNumeroFicheAsync(int etudiantId, int numeroFiche)
        {
            return await StratomFormDbContext.Fiches
                .Include(m => m.Activites)
                .Include(m => m.ActiviteTypes)
                .Include(m => m.AssurancesDommage)
                .Include(m => m.AssurancesPersonne)
                .Include(m => m.Concernes)
                .Include(m => m.ContratsPortefeuilles)
                .Include(m => m.DescriptionsActivite)
                .Include(m => m.Etudiants.Where(i => i.Id == etudiantId))
                .Include(m => m.FichesClientProspect)
                .Include(m => m.FichesContexteSimplifiee)
                .Include(m => m.FichesFin)
                .Include(m => m.Phases)
                .SingleOrDefaultAsync(m => m.NumeroFiche == numeroFiche);
        }

        public async Task<IEnumerable<Fiche>> GetAllFichesAsync()
        {
            return await StratomFormDbContext.Fiches
                .Include(m => m.Activites)
                .Include(m => m.ActiviteTypes)
                .Include(m => m.AssurancesDommage)
                .Include(m => m.AssurancesPersonne)
                .Include(m => m.Concernes)
                .Include(m => m.ContratsPortefeuilles)
                .Include(m => m.DescriptionsActivite)
                .Include(m => m.Etudiants)
                .Include(m => m.FichesClientProspect)
                .Include(m => m.FichesContexteSimplifiee)
                .Include(m => m.FichesFin)
                .Include(m => m.Phases)
                .ToListAsync();
        }
    }
}
