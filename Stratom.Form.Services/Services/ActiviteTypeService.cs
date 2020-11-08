using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class ActiviteTypeService : IActiviteTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActiviteTypeService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<ActiviteType> CreateActiviteType(ActiviteType newActiviteType)
        {
            await _unitOfWork.ActiviteTypes.AddAsync(newActiviteType);
            await _unitOfWork.CommitAsync();
            return newActiviteType;
        }

        public async Task DeleteActiviteType(ActiviteType activiteType)
        {
            _unitOfWork.ActiviteTypes.Remove(activiteType);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ActiviteType> GetActiviteTypeById(int id)
        {
            return await _unitOfWork.ActiviteTypes.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ActiviteType>> GetActiviteTypesByFicheId(int ficheId)
        {
            return await _unitOfWork.ActiviteTypes.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<ActiviteType>> GetAllWithFiche()
        {
            return await _unitOfWork.ActiviteTypes.GetAllWithFichesAsync();
        }

        public async Task UpdateActiviteType(ActiviteType typeActiviteToBeUpdated, ActiviteType typeActivite)
        {
            typeActiviteToBeUpdated.Libelle = typeActivite.Libelle;

            await _unitOfWork.CommitAsync();
        }
    }
}
