using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class ContratsPortefeuilleService : IContratsPortefeuilleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ContratsPortefeuilleService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<ContratsPortefeuille> CreateContratsPortefeuille(ContratsPortefeuille newContratsPortefeuille)
        {
            await _unitOfWork.ContratsPortefeuilles.AddAsync(newContratsPortefeuille);
            await _unitOfWork.CommitAsync();
            return newContratsPortefeuille;
        }

        public async Task DeleteContratsPortefeuille(ContratsPortefeuille contratsPortefeuille)
        {
            _unitOfWork.ContratsPortefeuilles.Remove(contratsPortefeuille);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ContratsPortefeuille> GetContratsPortefeuilleById(int id)
        {
            return await _unitOfWork.ContratsPortefeuilles.GetByIdAsync(id);
        }

        public async Task<IEnumerable<ContratsPortefeuille>> GetContratsPortefeuilleByFicheId(int ficheId)
        {
            return await _unitOfWork.ContratsPortefeuilles.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<ContratsPortefeuille>> GetAllWithFiche()
        {
            return await _unitOfWork.ContratsPortefeuilles.GetAllWithFichesAsync();
        }

        public async Task UpdateContratsPortefeuille(ContratsPortefeuille contratsPortefeuilleToBeUpdated, ContratsPortefeuille contratsPortefeuille)
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