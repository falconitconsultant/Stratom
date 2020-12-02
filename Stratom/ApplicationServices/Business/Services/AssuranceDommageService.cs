using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services
{
    public class AssuranceDommageService : IAssuranceDommageService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssuranceDommageService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<AssurancesDommage> CreateAssuranceDommage(AssurancesDommage newAssuranceDommage)
        {
            await _unitOfWork.AssurancesDommage.AddAsync(newAssuranceDommage);
            await _unitOfWork.CommitAsync();
            return newAssuranceDommage;
        }

        public async Task DeleteAssuranceDommage(AssurancesDommage assuranceDommage)
        {
            _unitOfWork.AssurancesDommage.Remove(assuranceDommage);
            await _unitOfWork.CommitAsync();
        }

        public async Task<AssurancesDommage> GetAssuranceDommageById(int id)
        {
            return await _unitOfWork.AssurancesDommage.GetByIdAsync(id);
        }

        //public async Task<IEnumerable<AssuranceDommage>> GetAssurancesDommageByFicheId(int ficheId)
        //{
        //    return await _unitOfWork.AssurancesDommage.GetAllWithFicheByFicheIdAsync(ficheId);
        //}

        //public async Task<IEnumerable<AssuranceDommage>> GetAllWithFiche()
        //{
        //    return await _unitOfWork.AssurancesDommage.GetAllWithFichesAsync();
        //}

        public async Task UpdateAssuranceDommage(AssurancesDommage assuranceDommageToBeUpdated, AssurancesDommage assuranceDommage)
        {
            assuranceDommageToBeUpdated.Libelle = assuranceDommage.Libelle;
            assuranceDommageToBeUpdated.Autre = assuranceDommage.Autre;

            await _unitOfWork.CommitAsync();
        }
    }
}
