using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IContratsPortefeuilleRepository : IRepository<ContratsPortefeuilles>
    {
        Task<IEnumerable<ContratsPortefeuilles>> GetAllWithFichesAsync();
        Task<ContratsPortefeuilles> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<ContratsPortefeuilles>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(ContratsPortefeuilles contratsPortefeuille);
        void Add(ContratsPortefeuilles contratsPortefeuille);
    }
}
