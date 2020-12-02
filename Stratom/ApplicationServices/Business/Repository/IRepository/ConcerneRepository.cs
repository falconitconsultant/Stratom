using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IConcerneRepository : IRepository<Concernes>
    {
        Task<IEnumerable<Concernes>> GetAllWithFichesAsync();
        Task<Concernes> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<Concernes>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(Concernes concerne);
    }
}
