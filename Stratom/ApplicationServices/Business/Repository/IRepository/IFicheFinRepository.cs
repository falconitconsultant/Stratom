using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IFicheFinRepository : IRepository<FichesFin>
    {
        Task<IEnumerable<FichesFin>> GetAllWithFichesAsync();
        Task<FichesFin> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<FichesFin>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(FichesFin ficheFin);
    }
}
