using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IFicheContexteSimplifieeService
    {
        Task<IEnumerable<FicheContexteSimplifiee>> GetAllWithFiche();
        Task<FicheContexteSimplifiee> GetFicheContexteSimplifieeById(int id);
        Task<IEnumerable<FicheContexteSimplifiee>> GetFicheContexteSimplifieeByFicheId(int ficheId);
        Task<FicheContexteSimplifiee> CreateFicheContexteSimplifiee(FicheContexteSimplifiee newFicheContexteSimplifiee);
        Task UpdateFicheContexteSimplifiee(FicheContexteSimplifiee ficheContexteSimplifieeToBeUpdated, FicheContexteSimplifiee ficheContexteSimplifiee);
        Task DeleteFicheContexteSimplifiee(FicheContexteSimplifiee ficheContexteSimplifiee);
    }
}
