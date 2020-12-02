using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services
{
    public class ContratsPortefeuilleService : IContratsPortefeuilleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContratsPortefeuilleService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<ContratsPortefeuilles> CreateContratsPortefeuille(ContratsPortefeuilles newContratsPortefeuille)
        {
            await _unitOfWork.ContratsPortefeuilles.AddAsync(newContratsPortefeuille);
            await _unitOfWork.CommitAsync();
            return newContratsPortefeuille;
        }

        public async Task DeleteContratsPortefeuille(ContratsPortefeuilles contratsPortefeuille)
        {
            _unitOfWork.ContratsPortefeuilles.Remove(contratsPortefeuille);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ContratsPortefeuilles> GetContratsPortefeuilleById(int id)
        {
            return await _unitOfWork.ContratsPortefeuilles.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ContratsPortefeuilles>> GetContratsPortefeuilleByFicheId(int ficheId)
        {
            return await _unitOfWork.ContratsPortefeuilles.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<ContratsPortefeuilles>> GetAllWithFiche()
        {
            return await _unitOfWork.ContratsPortefeuilles.GetAllWithFichesAsync();
        }

        public async Task UpdateContratsPortefeuille(ContratsPortefeuilles contratsPortefeuilleToBeUpdated, ContratsPortefeuilles contratsPortefeuille)
        {
            contratsPortefeuilleToBeUpdated.Type = contratsPortefeuille.Type;
            contratsPortefeuilleToBeUpdated.Garantie = contratsPortefeuille.Garantie;
            contratsPortefeuilleToBeUpdated.DateSouscription = contratsPortefeuille.DateSouscription;
            contratsPortefeuilleToBeUpdated.CotisationAnnuelle = contratsPortefeuille.CotisationAnnuelle;
            contratsPortefeuilleToBeUpdated.Autre = contratsPortefeuille.Autre;

            await _unitOfWork.CommitAsync();
        }
    }
}