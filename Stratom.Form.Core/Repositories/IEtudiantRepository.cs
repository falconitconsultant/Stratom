using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IEtudiantRepository : IRepository<Etudiant>
    {
        Task<IEnumerable<Etudiant>> GetAllWithFichesAsync();
        Task<Etudiant> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<Etudiant>> GetAllWithFicheByFicheIdAsync(int ficheId);
    }
}
