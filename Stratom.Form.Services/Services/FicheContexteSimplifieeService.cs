using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class FicheContexteSimplifieeService : IFicheContexteSimplifieeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FicheContexteSimplifieeService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<FicheContexteSimplifiee> CreateFicheContexteSimplifiee(FicheContexteSimplifiee newFicheContexteSimplifiee)
        {
            await _unitOfWork.FichesContexteSimplifiee.AddAsync(newFicheContexteSimplifiee);
            await _unitOfWork.CommitAsync();
            return newFicheContexteSimplifiee;
        }

        public async Task DeleteFicheContexteSimplifiee(FicheContexteSimplifiee ficheContexteSimplifiee)
        {
            _unitOfWork.FichesContexteSimplifiee.Remove(ficheContexteSimplifiee);
            await _unitOfWork.CommitAsync();
        }

        public async Task<FicheContexteSimplifiee> GetFicheContexteSimplifieeById(int id)
        {
            return await _unitOfWork.FichesContexteSimplifiee.GetByIdAsync(id);
        }

        public async Task<IEnumerable<FicheContexteSimplifiee>> GetFicheContexteSimplifieeByFicheId(int ficheId)
        {
            return await _unitOfWork.FichesContexteSimplifiee.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<FicheContexteSimplifiee>> GetAllWithFiche()
        {
            return await _unitOfWork.FichesContexteSimplifiee.GetAllWithFichesAsync();
        }

        public async Task UpdateFicheContexteSimplifiee(FicheContexteSimplifiee ficheContexteSimplifieeToBeUpdated, FicheContexteSimplifiee ficheContexteSimplifiee)
        {
            ficheContexteSimplifieeToBeUpdated.EntrepriseNom = ficheContexteSimplifiee.EntrepriseNom;
            ficheContexteSimplifieeToBeUpdated.CompagnieMandante = ficheContexteSimplifiee.CompagnieMandante;
            ficheContexteSimplifieeToBeUpdated.Historique = ficheContexteSimplifiee.Historique;
            ficheContexteSimplifieeToBeUpdated.PresentationPortefeuilleClients = ficheContexteSimplifiee.PresentationPortefeuilleClients;
            ficheContexteSimplifieeToBeUpdated.ActivitesEntreprise = ficheContexteSimplifiee.ActivitesEntreprise;
            ficheContexteSimplifieeToBeUpdated.Cible = ficheContexteSimplifiee.Cible;
            ficheContexteSimplifieeToBeUpdated.ActionsCommerciales = ficheContexteSimplifiee.ActionsCommerciales;
            ficheContexteSimplifieeToBeUpdated.ReductionsNature = ficheContexteSimplifiee.ReductionsNature;
            ficheContexteSimplifieeToBeUpdated.ReductionsMontant = ficheContexteSimplifiee.ReductionsMontant;
            ficheContexteSimplifieeToBeUpdated.ReductionsPeriode = ficheContexteSimplifiee.ReductionsPeriode;
            ficheContexteSimplifieeToBeUpdated.ReductionsAutre = ficheContexteSimplifiee.ReductionsAutre;

            await _unitOfWork.CommitAsync();
        }
    }
}