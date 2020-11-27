using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IPhaseRepository : IRepository<Phase>
    {
        Task<IEnumerable<Phase>> GetAllWithFichesAsync();
        Task<Phase> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<Phase>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(Phase phase);
    }
}
