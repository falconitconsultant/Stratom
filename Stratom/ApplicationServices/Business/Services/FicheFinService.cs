using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services
{
    public class FicheFinService : IFicheFinService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FicheFinService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<FichesFin> CreateFicheFin(FichesFin newFicheFin)
        {
            await _unitOfWork.FichesFin.AddAsync(newFicheFin);
            await _unitOfWork.CommitAsync();
            return newFicheFin;
        }

        public async Task DeleteFicheFin(FichesFin ficheFin)
        {
            _unitOfWork.FichesFin.Remove(ficheFin);
            await _unitOfWork.CommitAsync();
        }

        public async Task<FichesFin> GetFicheFinById(int id)
        {
            return await _unitOfWork.FichesFin.GetByIdAsync(id);
        }

        public async Task<IEnumerable<FichesFin>> GetFicheFinByFicheId(int ficheId)
        {
            return await _unitOfWork.FichesFin.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<FichesFin>> GetAllWithFiche()
        {
            return await _unitOfWork.FichesFin.GetAllWithFichesAsync();
        }

        public async Task UpdateFicheFin(FichesFin ficheFinToBeUpdated, FichesFin ficheFin)
        {
            //ficheFinToBeUpdated.InformationsAConserver = ficheFin.InformationsAConserver;
            ficheFinToBeUpdated.PlanificationActions = ficheFin.PlanificationActions;
            ficheFinToBeUpdated.AutoEvaluation = ficheFin.AutoEvaluation;

            await _unitOfWork.CommitAsync();
        }
    }
}