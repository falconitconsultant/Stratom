using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IActiviteTypeService
    {
        Task<IEnumerable<ActiviteType>> GetAllWithFiche();
        Task<ActiviteType> GetActiviteTypeById(int id);
        Task<IEnumerable<ActiviteType>> GetActiviteTypesByFicheId(int ficheId);
        Task<ActiviteType> CreateActiviteType(ActiviteType newActiviteType);
        Task UpdateActiviteType(ActiviteType activiteTypeToBeUpdated, ActiviteType activiteType);
        Task DeleteActiviteType(ActiviteType activiteType);
    }
}
