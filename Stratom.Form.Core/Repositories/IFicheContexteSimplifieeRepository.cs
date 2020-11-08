using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IFicheContexteSimplifieeRepository : IRepository<FicheContexteSimplifiee>
    {
        Task<IEnumerable<FicheContexteSimplifiee>> GetAllWithFichesAsync();
        Task<FicheContexteSimplifiee> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<FicheContexteSimplifiee>> GetAllWithFicheByFicheIdAsync(int ficheId);
    }
}
