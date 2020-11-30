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
    public class FicheContexteSimplifieeRepository : Repository<FicheContexteSimplifiee>, IFicheContexteSimplifieeRepository
    {
        public FicheContexteSimplifieeRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<FicheContexteSimplifiee>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.FichesContexteSimplifiee.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<FicheContexteSimplifiee> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.FichesContexteSimplifiee.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<FicheContexteSimplifiee>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.FichesContexteSimplifiee.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }

        public void Update(FicheContexteSimplifiee ficheContexteSimplifiee)
        {
            var objFromDb = StratomFormDbContext.FichesContexteSimplifiee.FirstOrDefault(c => c.Id == ficheContexteSimplifiee.Id);
            objFromDb.EntrepriseNom = ficheContexteSimplifiee.EntrepriseNom;
            objFromDb.CompagnieMandante = ficheContexteSimplifiee.CompagnieMandante;
            objFromDb.Historique = ficheContexteSimplifiee.Historique;
            objFromDb.PresentationPortefeuilleClients = ficheContexteSimplifiee.PresentationPortefeuilleClients;
            objFromDb.ActivitesEntreprise = ficheContexteSimplifiee.ActivitesEntreprise;
            objFromDb.Cible = ficheContexteSimplifiee.Cible;
            objFromDb.ActionsCommerciales = ficheContexteSimplifiee.ActionsCommerciales;
            objFromDb.ReductionsNature = ficheContexteSimplifiee.ReductionsNature;
            objFromDb.ReductionsMontant = ficheContexteSimplifiee.ReductionsMontant;
            objFromDb.ReductionsPeriode = ficheContexteSimplifiee.ReductionsPeriode;
            objFromDb.ReductionsAutre = ficheContexteSimplifiee.ReductionsAutre;
            StratomFormDbContext.SaveChanges();
        }
    }
}
