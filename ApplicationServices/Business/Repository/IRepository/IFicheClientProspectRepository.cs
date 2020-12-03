using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IFicheClientProspectRepository : IRepository<FichesClientProspect>
    {
        Task<IEnumerable<FichesClientProspect>> GetAllWithFichesAsync();
        Task<FichesClientProspect> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<FichesClientProspect>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(FichesClientProspect ficheClientProspect);
        void Add(FichesClientProspect ficheClientProspect);
    }
}
