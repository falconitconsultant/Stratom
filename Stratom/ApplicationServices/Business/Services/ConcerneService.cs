using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services
{
    public class ConcerneService : IConcerneService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConcerneService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Concernes> CreateConcerne(Concernes newConcerne)
        {
            await _unitOfWork.Concernes.AddAsync(newConcerne);
            await _unitOfWork.CommitAsync();
            return newConcerne;
        }

        public async Task DeleteConcerne(Concernes concerne)
        {
            _unitOfWork.Concernes.Remove(concerne);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Concernes> GetConcerneById(int id)
        {
            return await _unitOfWork.Concernes.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Concernes>> GetConcernesByFicheId(int ficheId)
        {
            return await _unitOfWork.Concernes.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<Concernes>> GetAllWithFiche()
        {
            return await _unitOfWork.Concernes.GetAllWithFichesAsync();
        }

        public async Task UpdateConcerne(Concernes concerneToBeUpdated, Concernes concerne)
        {
            concerneToBeUpdated.Libelle = concerne.Libelle;

            await _unitOfWork.CommitAsync();
        }
    }
}
