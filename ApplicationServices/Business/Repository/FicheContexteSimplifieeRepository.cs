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
    public class FicheContexteSimplifieeRepository : Repository<FichesContexteSimplifiee>, IFicheContexteSimplifieeRepository
    {
        public FicheContexteSimplifieeRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        public async Task<IEnumerable<FichesContexteSimplifiee>> GetAllWithFichesAsync()
        {
            return await StratomContext.FichesContexteSimplifiee.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<FichesContexteSimplifiee> GetWithFichesByIdAsync(int id)
        {
            return await StratomContext.FichesContexteSimplifiee.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.FicheId == id);
        }

        public async Task<IEnumerable<FichesContexteSimplifiee>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomContext.FichesContexteSimplifiee.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }

        public void Update(FichesContexteSimplifiee ficheContexteSimplifiee)
        {
            var objFromDb = StratomContext.FichesContexteSimplifiee.FirstOrDefault(c => c.Id == ficheContexteSimplifiee.Id);
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
            StratomContext.SaveChanges();
        }

        public void Add(FichesContexteSimplifiee ficheContexteSimplifiee)
        {
            StratomContext.FichesContexteSimplifiee.Add(ficheContexteSimplifiee);
            StratomContext.SaveChanges();
        }
    }
}
