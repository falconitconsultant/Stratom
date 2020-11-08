using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IFicheClientProspectService
    {
        Task<IEnumerable<FicheClientProspect>> GetAllWithFiche();
        Task<FicheClientProspect> GetFicheClientProspectById(int id);
        Task<IEnumerable<FicheClientProspect>> GetFicheClientProspectByFicheId(int ficheId);
        Task<FicheClientProspect> CreateFicheClientProspect(FicheClientProspect newFicheClientProspect);
        Task UpdateFicheClientProspect(FicheClientProspect ficheClientProspectToBeUpdated, FicheClientProspect ficheClientProspect);
        Task DeleteFicheClientProspect(FicheClientProspect ficheClientProspect);
    }
}
