using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class ConcerneService : IConcerneService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConcerneService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Concerne> CreateConcerne(Concerne newConcerne)
        {
            await _unitOfWork.Concernes.AddAsync(newConcerne);
            await _unitOfWork.CommitAsync();
            return newConcerne;
        }

        public async Task DeleteConcerne(Concerne concerne)
        {
            _unitOfWork.Concernes.Remove(concerne);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Concerne> GetConcerneById(int id)
        {
            return await _unitOfWork.Concernes.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Concerne>> GetConcernesByFicheId(int ficheId)
        {
            return await _unitOfWork.Concernes.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<Concerne>> GetAllWithFiche()
        {
            return await _unitOfWork.Concernes.GetAllWithFichesAsync();
        }

        public async Task UpdateConcerne(Concerne concerneToBeUpdated, Concerne concerne)
        {
            concerneToBeUpdated.Libelle = concerne.Libelle;

            await _unitOfWork.CommitAsync();
        }
    }
}
