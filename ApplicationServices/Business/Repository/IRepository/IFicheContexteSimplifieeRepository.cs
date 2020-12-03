using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IFicheContexteSimplifieeRepository : IRepository<FichesContexteSimplifiee>
    {
        Task<IEnumerable<FichesContexteSimplifiee>> GetAllWithFichesAsync();
        Task<FichesContexteSimplifiee> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<FichesContexteSimplifiee>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(FichesContexteSimplifiee ficheContexteSimplifiee);
        void Add(FichesContexteSimplifiee ficheContexteSimplifiee);
    }
}
