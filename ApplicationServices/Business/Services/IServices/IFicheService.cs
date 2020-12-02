using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IFicheService
    {
        Task<IEnumerable<Fiches>> GetAllFiches();
        Task<MainViewModel> GetAllFichesInViewModel(string id);
        Task<Fiches> GetFicheById(int id);        
        Task<Fiches> CreateFiche(Fiches newFiche);
        Task UpdateFiche(Fiches ficheToBeUpdated, Fiches fiche);
        Task DeleteFiche(Fiches fiche);
    }
}
