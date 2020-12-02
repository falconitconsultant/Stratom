using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services
{
    public class AssurancePersonneService : IAssurancePersonneService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssurancePersonneService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<AssurancesPersonne> CreateAssurancePersonne(AssurancesPersonne newAssurancePersonne)
        {
            await _unitOfWork.AssurancesPersonne.AddAsync(newAssurancePersonne);
            await _unitOfWork.CommitAsync();
            return newAssurancePersonne;
        }

        public async Task DeleteAssurancePersonne(AssurancesPersonne assurancePersonne)
        {
            _unitOfWork.AssurancesPersonne.Remove(assurancePersonne);
            await _unitOfWork.CommitAsync();
        }

        public async Task<AssurancesPersonne> GetAssurancePersonneById(int id)
        {
            return await _unitOfWork.AssurancesPersonne.GetByIdAsync(id);
        }

        //public async Task<IEnumerable<AssurancePersonne>> GetAssurancesPersonneByFicheId(int ficheId)
        //{
        //    return await _unitOfWork.AssurancesPersonne.GetAllWithFicheByFicheIdAsync(ficheId);
        //}

        //public async Task<IEnumerable<AssurancePersonne>> GetAllWithFiche()
        //{
        //    return await _unitOfWork.AssurancesPersonne.GetAllWithFichesAsync();
        //}

        public async Task UpdateAssurancePersonne(AssurancesPersonne assurancePersonneToBeUpdated, AssurancesPersonne assurancePersonne)
        {
            assurancePersonneToBeUpdated.Libelle = assurancePersonne.Libelle;
            assurancePersonneToBeUpdated.Autre = assurancePersonne.Autre;

            await _unitOfWork.CommitAsync();
        }
    }
}
