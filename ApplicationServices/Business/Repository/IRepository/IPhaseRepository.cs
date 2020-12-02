using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IPhaseRepository : IRepository<Phases>
    {
        Task<IEnumerable<Phases>> GetAllWithFichesAsync();
        Task<Phases> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<Phases>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(Phases phase);
    }
}
