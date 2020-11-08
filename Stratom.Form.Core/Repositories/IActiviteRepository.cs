using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IActiviteRepository : IRepository<Activite>
    {
        Task<IEnumerable<Activite>> GetAllWithFichesAsync();
        Task<Activite> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<Activite>> GetAllWithFicheByFicheIdAsync(int ficheId);
    }
}
