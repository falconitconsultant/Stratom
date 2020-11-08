using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class FicheFinService : IFicheFinService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FicheFinService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<FicheFin> CreateFicheFin(FicheFin newFicheFin)
        {
            await _unitOfWork.FichesFin.AddAsync(newFicheFin);
            await _unitOfWork.CommitAsync();
            return newFicheFin;
        }

        public async Task DeleteFicheFin(FicheFin ficheFin)
        {
            _unitOfWork.FichesFin.Remove(ficheFin);
            await _unitOfWork.CommitAsync();
        }

        public async Task<FicheFin> GetFicheFinById(int id)
        {
            return await _unitOfWork.FichesFin.GetByIdAsync(id);
        }

        public async Task<IEnumerable<FicheFin>> GetFicheFinByFicheId(int ficheId)
        {
            return await _unitOfWork.FichesFin.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<FicheFin>> GetAllWithFiche()
        {
            return await _unitOfWork.FichesFin.GetAllWithFichesAsync();
        }

        public async Task UpdateFicheFin(FicheFin ficheFinToBeUpdated, FicheFin ficheFin)
        {
            ficheFinToBeUpdated.InformationsAConserver = ficheFin.InformationsAConserver;
            ficheFinToBeUpdated.PlanificationActions = ficheFin.PlanificationActions;
            ficheFinToBeUpdated.AutoEvaluation = ficheFin.AutoEvaluation;

            await _unitOfWork.CommitAsync();
        }
    }
}