using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IContratsPortefeuilleRepository : IRepository<ContratsPortefeuille>
    {
        Task<IEnumerable<ContratsPortefeuille>> GetAllWithFichesAsync();
        Task<ContratsPortefeuille> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<ContratsPortefeuille>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(ContratsPortefeuille contratsPortefeuille);
    }
}
