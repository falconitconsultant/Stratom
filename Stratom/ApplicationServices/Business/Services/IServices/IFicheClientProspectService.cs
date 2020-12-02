using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IFicheClientProspectService
    {
        Task<IEnumerable<FichesClientProspect>> GetAllWithFiche();
        Task<FichesClientProspect> GetFicheClientProspectById(int id);
        Task<IEnumerable<FichesClientProspect>> GetFicheClientProspectByFicheId(int ficheId);
        Task<FichesClientProspect> CreateFicheClientProspect(FichesClientProspect newFicheClientProspect);
        Task UpdateFicheClientProspect(FichesClientProspect ficheClientProspectToBeUpdated, FichesClientProspect ficheClientProspect);
        Task DeleteFicheClientProspect(FichesClientProspect ficheClientProspect);
    }
}
