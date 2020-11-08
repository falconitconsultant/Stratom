using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class DescriptionActiviteService : IDescriptionActiviteService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DescriptionActiviteService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<DescriptionActivite> CreateDescriptionActivite(DescriptionActivite newDescriptionActivite)
        {
            await _unitOfWork.DescriptionsActivite.AddAsync(newDescriptionActivite);
            await _unitOfWork.CommitAsync();
            return newDescriptionActivite;
        }

        public async Task DeleteDescriptionActivite(DescriptionActivite descriptionActivite)
        {
            _unitOfWork.DescriptionsActivite.Remove(descriptionActivite);
            await _unitOfWork.CommitAsync();
        }

        public async Task<DescriptionActivite> GetDescriptionActiviteById(int id)
        {
            return await _unitOfWork.DescriptionsActivite.GetByIdAsync(id);
        }

        public async Task<IEnumerable<DescriptionActivite>> GetDescriptionsActiviteByFicheId(int ficheId)
        {
            return await _unitOfWork.DescriptionsActivite.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<DescriptionActivite>> GetAllWithFiche()
        {
            return await _unitOfWork.DescriptionsActivite.GetAllWithFichesAsync();
        }

        public async Task UpdateDescriptionActivite(DescriptionActivite descriptionActiviteToBeUpdated, DescriptionActivite descriptionActivite)
        {
            descriptionActiviteToBeUpdated.ContactOrigine = descriptionActivite.ContactOrigine;
            descriptionActiviteToBeUpdated.ContactFaceAFace = descriptionActivite.ContactFaceAFace;
            descriptionActiviteToBeUpdated.ContactTelephone = descriptionActivite.ContactTelephone;
            descriptionActiviteToBeUpdated.ContactRole = descriptionActivite.ContactRole;
            descriptionActiviteToBeUpdated.ContactFonction = descriptionActivite.ContactFonction;
            descriptionActiviteToBeUpdated.EntretienObjectifs = descriptionActivite.EntretienObjectifs;
            descriptionActiviteToBeUpdated.EntretienDeroulement = descriptionActivite.EntretienDeroulement;

            await _unitOfWork.CommitAsync();
        }
    }
}