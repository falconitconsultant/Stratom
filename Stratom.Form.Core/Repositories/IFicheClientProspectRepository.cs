using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IFicheClientProspectRepository : IRepository<FicheClientProspect>
    {
        Task<IEnumerable<FicheClientProspect>> GetAllWithFichesAsync();
        Task<FicheClientProspect> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<FicheClientProspect>> GetAllWithFicheByFicheIdAsync(int ficheId);
    }
}
