using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IDescriptionActiviteRepository : IRepository<DescriptionActivite>
    {
        Task<IEnumerable<DescriptionActivite>> GetAllWithFichesAsync();
        Task<DescriptionActivite> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<DescriptionActivite>> GetAllWithFicheByFicheIdAsync(int ficheId);
    }
}
