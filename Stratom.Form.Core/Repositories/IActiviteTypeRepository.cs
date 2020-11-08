using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IActiviteTypeRepository : IRepository<ActiviteType>
    {
        Task<IEnumerable<ActiviteType>> GetAllWithFichesAsync();
        Task<ActiviteType> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<ActiviteType>> GetAllWithFicheByFicheIdAsync(int ficheId);
    }
}
