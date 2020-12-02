using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IFicheContexteSimplifieeService
    {
        Task<IEnumerable<FichesContexteSimplifiee>> GetAllWithFiche();
        Task<FichesContexteSimplifiee> GetFicheContexteSimplifieeById(int id);
        Task<IEnumerable<FichesContexteSimplifiee>> GetFicheContexteSimplifieeByFicheId(int ficheId);
        Task<FichesContexteSimplifiee> CreateFicheContexteSimplifiee(FichesContexteSimplifiee newFicheContexteSimplifiee);
        Task UpdateFicheContexteSimplifiee(FichesContexteSimplifiee ficheContexteSimplifieeToBeUpdated, FichesContexteSimplifiee ficheContexteSimplifiee);
        Task DeleteFicheContexteSimplifiee(FichesContexteSimplifiee ficheContexteSimplifiee);
    }
}
