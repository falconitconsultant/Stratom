using Microsoft.AspNetCore.Components;
using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class FicheService : IFicheService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly HttpClient _httpClient;
        public FicheService(IUnitOfWork unitOfWork, HttpClient httpClient)
        {
            this._unitOfWork = unitOfWork;
            this._httpClient = httpClient;
        }

        public async Task<IEnumerable<Fiche>> GetAllFiches()
        {
            return await _httpClient.GetJsonAsync<Fiche[]>("api/Fiches");
            //return await _unitOfWork.Fiches.GetAllAsync();
        }

        public async Task<Fiche> GetFicheById(int id)
        {
            return await _unitOfWork.Fiches.GetAllByIdAsync(id);
        }

        public async Task<Fiche> CreateFiche(Fiche newFiche)
        {
            await _unitOfWork.Fiches.AddAsync(newFiche);
            await _unitOfWork.CommitAsync();
            return newFiche;
        }

        public async Task UpdateFiche(Fiche ficheToBeUpdated, Fiche fiche)
        {
            ficheToBeUpdated.Activites = fiche.Activites;
            ficheToBeUpdated.ActiviteTypes = fiche.ActiviteTypes;
            ficheToBeUpdated.AssurancesDommage = fiche.AssurancesDommage;
            ficheToBeUpdated.AssurancesPersonne = fiche.AssurancesPersonne;
            ficheToBeUpdated.Concernes = fiche.Concernes;
            ficheToBeUpdated.ContratsPortefeuilles = fiche.ContratsPortefeuilles;
            ficheToBeUpdated.DescriptionsActivite = fiche.DescriptionsActivite;
            ficheToBeUpdated.FichesClientProspect = fiche.FichesClientProspect;
            ficheToBeUpdated.FichesContexteSimplifiee = fiche.FichesContexteSimplifiee;
            ficheToBeUpdated.FichesFin = fiche.FichesFin;
            ficheToBeUpdated.Phases = fiche.Phases;
            ficheToBeUpdated.NumeroFiche = fiche.NumeroFiche;

            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteFiche(Fiche fiche)
        {
            _unitOfWork.Fiches.Remove(fiche);
            await _unitOfWork.CommitAsync();
        }
    }
}
