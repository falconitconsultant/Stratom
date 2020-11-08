using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IAssurancePersonneRepository : IRepository<AssurancePersonne>
    {
        Task<IEnumerable<AssurancePersonne>> GetAllWithFichesAsync();
        Task<AssurancePersonne> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<AssurancePersonne>> GetAllWithFicheByFicheIdAsync(int ficheId);
    }
}
