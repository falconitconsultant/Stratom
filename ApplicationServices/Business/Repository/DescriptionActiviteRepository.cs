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
    public class DescriptionActiviteRepository : Repository<DescriptionsActivite>, IDescriptionActiviteRepository
    {
        public DescriptionActiviteRepository(StratomContext context)
            : base(context)
        { }

        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }

        public async Task<IEnumerable<DescriptionsActivite>> GetAllWithFichesAsync()
        {
            return await StratomContext.DescriptionsActivite.Include(m => m.Fiche).ToListAsync();
        }

        public async Task<DescriptionsActivite> GetWithFichesByIdAsync(int id)
        {
            return await StratomContext.DescriptionsActivite.Include(m => m.Fiche).SingleOrDefaultAsync(m => m.FicheId == id);
        }

        public async Task<IEnumerable<DescriptionsActivite>> GetAllWithFicheByFicheIdAsync(int ficheId)
        {
            return await StratomContext.DescriptionsActivite.Include(m => m.Fiche).Where(m => m.FicheId == ficheId).ToListAsync();
        }

        public void Update(DescriptionsActivite descriptionActivite)
        {
            var objFromDb = StratomContext.DescriptionsActivite.FirstOrDefault(c => c.Id == descriptionActivite.Id);
            objFromDb.ContactOrigine = descriptionActivite.ContactOrigine;
            //objFromDb.ContactFaceAFace = descriptionActivite.ContactFaceAFace;
            //objFromDb.ContactTelephone = descriptionActivite.ContactTelephone;
            objFromDb.ContactRole = descriptionActivite.ContactRole;
            objFromDb.ContactFonction = descriptionActivite.ContactFonction;
            objFromDb.EntretienObjectifs = descriptionActivite.EntretienObjectifs;
            objFromDb.EntretienDeroulement = descriptionActivite.EntretienDeroulement;
            StratomContext.SaveChanges();
        }

        public void Add(DescriptionsActivite descriptionActivite)
        {
            StratomContext.DescriptionsActivite.Add(descriptionActivite);
            StratomContext.SaveChanges();
        }
    }
}
