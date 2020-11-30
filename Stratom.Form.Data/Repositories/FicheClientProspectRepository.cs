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
    public class FicheClientProspectRepository : Repository<FicheClientProspect>, IFicheClientProspectRepository
    {
        public FicheClientProspectRepository(StratomFormDbContext context)
            : base(context)
        { }

        private StratomFormDbContext StratomFormDbContext
        {
            get { return Context as StratomFormDbContext; }
        }

        public async Task<IEnumerable<FicheClientProspect>> GetAllWithFichesAsync()
        {
            return await StratomFormDbContext.FichesClientProspect.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<FicheClientProspect> GetWithFichesByIdAsync(int id)
        {
            return await StratomFormDbContext.FichesClientProspect.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task<IEnumerable<FicheClientProspect>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomFormDbContext.FichesClientProspect.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }

        public void Update(FicheClientProspect ficheClientProspect)
        {
            var objFromDb = StratomFormDbContext.FichesClientProspect.FirstOrDefault(c => c.Id == ficheClientProspect.Id);
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
            StratomFormDbContext.SaveChanges();
        }
    }
}
