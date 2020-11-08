using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IFicheFinRepository : IRepository<FicheFin>
    {
        Task<IEnumerable<FicheFin>> GetAllWithFichesAsync();
        Task<FicheFin> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<FicheFin>> GetAllWithFicheByFicheIdAsync(int ficheId);
    }
}
