using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IActiviteService
    {
        Task<IEnumerable<Activite>> GetAllWithFiche();
        Task<Activite> GetActiviteById(int id);
        Task<IEnumerable<Activite>> GetActivitesByFicheId(int ficheId);
        Task<Activite> CreateActivite(Activite newActivite);
        Task UpdateActivite(Activite activiteToBeUpdated, Activite activite);
        Task DeleteActivite(Activite activite);
    }
}
