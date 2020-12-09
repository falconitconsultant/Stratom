using ApplicationServices;
using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Components;
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

        public async Task<IEnumerable<Fiches>> GetAllFiches()
        {
            return await _httpClient.GetJsonAsync<Fiches[]>("api/Fiches");
            //return await _unitOfWork.Fiches.GetAllAsync();
        }
        public async Task<MainViewModel> GetAllFichesInViewModel(string id)
        {
            //MainViewModel model = new MainViewModel();
            //Fiche fiche = await _unitOfWork.Fiches.GetAllFichesByStudentId(id);
            //model.fiche = fiche;
            //return model;
            return await _httpClient.GetJsonAsync<MainViewModel>("api/Fiches/?id="+ id);
        }
        public async Task<Fiches> GetFicheById(int id)
        {
            return await _unitOfWork.Fiches.GetAllByIdAsync(id);
        }
        public async Task<IEnumerable<Fiches>> GetFicheByStudentId(string StudentId)
        {
            return await _httpClient.GetJsonAsync<IEnumerable<Fiches>>("api/Fiches/GetAllDocuments/" + StudentId);
        }
        public async Task<Fiches> CreateFiche(Fiches newFiche)
        {
            await _unitOfWork.Fiches.AddAsync(newFiche);
            await _unitOfWork.CommitAsync();
            return newFiche;
        }

        public async Task UpdateFiche(Fiches ficheToBeUpdated, Fiches fiche)
        {
            ficheToBeUpdated.Activites = fiche.Activites;
            //ficheToBeUpdated.ActiviteTypes = fiche.ActiviteTypes;
            //ficheToBeUpdated.AssurancesDommage = fiche.AssurancesDommage;
            //ficheToBeUpdated.AssurancesPersonne = fiche.AssurancesPersonne;
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

        public async Task DeleteFiche(Fiches fiche)
        {
            _unitOfWork.Fiches.Remove(fiche);
            await _unitOfWork.CommitAsync();
        }
    }
}
