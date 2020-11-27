using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IAssuranceDommageRepository : IRepository<AssuranceDommage>
    {
        Task<IEnumerable<AssuranceDommage>> GetAllWithFichesAsync();
        Task<AssuranceDommage> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<AssuranceDommage>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(AssuranceDommage assuranceDommage);
    }
}
