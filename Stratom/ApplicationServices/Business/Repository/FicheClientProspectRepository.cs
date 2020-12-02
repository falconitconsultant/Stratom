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
    public class FicheClientProspectRepository : Repository<FichesClientProspect>, IFicheClientProspectRepository
    {
        public FicheClientProspectRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        public async Task<IEnumerable<FichesClientProspect>> GetAllWithFichesAsync()
        {
            return await StratomContext.FichesClientProspect.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<FichesClientProspect> GetWithFichesByIdAsync(int id)
        {
            return await StratomContext.FichesClientProspect.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<FichesClientProspect>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomContext.FichesClientProspect.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }

        public void Update(FichesClientProspect ficheClientProspect)
        {
            var objFromDb = StratomContext.FichesClientProspect.FirstOrDefault(c => c.Id == ficheClientProspect.Id);
            objFromDb.Nom = ficheClientProspect.Nom;
            objFromDb.Prenom = ficheClientProspect.Prenom;
            objFromDb.Sexe = ficheClientProspect.Sexe;
            objFromDb.Age = ficheClientProspect.Age;
            objFromDb.Adresse = ficheClientProspect.Adresse;
            objFromDb.CodePostal = ficheClientProspect.CodePostal;
            objFromDb.Ville = ficheClientProspect.Ville;
            objFromDb.Telephone = ficheClientProspect.Telephone;
            objFromDb.Mobile = ficheClientProspect.Mobile;
            objFromDb.Mail = ficheClientProspect.Mail;
            objFromDb.Autre = ficheClientProspect.Autre;
            objFromDb.SituationFamiliale = ficheClientProspect.SituationFamiliale;
            objFromDb.NbEnfants = ficheClientProspect.NbEnfants;
            objFromDb.AgesEnfants = ficheClientProspect.AgesEnfants;
            objFromDb.SituationProfessionnelle = ficheClientProspect.SituationProfessionnelle;
            objFromDb.IsClient = ficheClientProspect.IsClient;
            objFromDb.Statut = ficheClientProspect.Statut;
            objFromDb.Anciennete = ficheClientProspect.Anciennete;
            objFromDb.Revenus = ficheClientProspect.Revenus;
            objFromDb.TauxImposition = ficheClientProspect.TauxImposition;
            objFromDb.Placements = ficheClientProspect.Placements;
            StratomContext.SaveChanges();
        }
    }
}
