using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IFicheService
    {
        Task<IEnumerable<Fiche>> GetAllFiches();
        Task<Fiche> GetFicheById(int id);        
        Task<Fiche> CreateFiche(Fiche newFiche);
        Task UpdateFiche(Fiche ficheToBeUpdated, Fiche fiche);
        Task DeleteFiche(Fiche fiche);
    }
}
