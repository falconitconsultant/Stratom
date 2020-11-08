using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class AssurancePersonneService : IAssurancePersonneService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AssurancePersonneService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<AssurancePersonne> CreateAssurancePersonne(AssurancePersonne newAssurancePersonne)
        {
            await _unitOfWork.AssurancesPersonne.AddAsync(newAssurancePersonne);
            await _unitOfWork.CommitAsync();
            return newAssurancePersonne;
        }

        public async Task DeleteAssurancePersonne(AssurancePersonne assurancePersonne)
        {
            _unitOfWork.AssurancesPersonne.Remove(assurancePersonne);
            await _unitOfWork.CommitAsync();
        }

        public async Task<AssurancePersonne> GetAssurancePersonneById(int id)
        {
            return await _unitOfWork.AssurancesPersonne.GetByIdAsync(id);
        }

        public async Task<IEnumerable<AssurancePersonne>> GetAssurancesPersonneByFicheId(int ficheId)
        {
            return await _unitOfWork.AssurancesPersonne.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<AssurancePersonne>> GetAllWithFiche()
        {
            return await _unitOfWork.AssurancesPersonne.GetAllWithFichesAsync();
        }

        public async Task UpdateAssurancePersonne(AssurancePersonne assurancePersonneToBeUpdated, AssurancePersonne assurancePersonne)
        {
            assurancePersonneToBeUpdated.Libelle = assurancePersonne.Libelle;
            assurancePersonneToBeUpdated.Autre = assurancePersonne.Autre;

            await _unitOfWork.CommitAsync();
        }
    }
}
