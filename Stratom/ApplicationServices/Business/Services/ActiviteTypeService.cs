using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services
{
    public class ActiviteTypeService : IActiviteTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActiviteTypeService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<ActiviteTypes> CreateActiviteType(ActiviteTypes newActiviteType)
        {
            await _unitOfWork.ActiviteTypes.AddAsync(newActiviteType);
            await _unitOfWork.CommitAsync();
            return newActiviteType;
        }

        public async Task DeleteActiviteType(ActiviteTypes activiteType)
        {
            _unitOfWork.ActiviteTypes.Remove(activiteType);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ActiviteTypes> GetActiviteTypeById(int id)
        {
            return await _unitOfWork.ActiviteTypes.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ActiviteTypes>> GetActiviteTypesByFicheId(int ficheId)
        {
            return await _unitOfWork.ActiviteTypes.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<ActiviteTypes>> GetAllWithFiche()
        {
            return await _unitOfWork.ActiviteTypes.GetAllWithFichesAsync();
        }

        public async Task UpdateActiviteType(ActiviteTypes typeActiviteToBeUpdated, ActiviteTypes typeActivite)
        {
            typeActiviteToBeUpdated.Libelle = typeActivite.Libelle;

            await _unitOfWork.CommitAsync();
        }
    }
}
