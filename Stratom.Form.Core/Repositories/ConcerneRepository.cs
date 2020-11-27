using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IConcerneRepository : IRepository<Concerne>
    {
        Task<IEnumerable<Concerne>> GetAllWithFichesAsync();
        Task<Concerne> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<Concerne>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(Concerne concerne);
    }
}
