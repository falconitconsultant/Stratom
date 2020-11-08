using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IAssuranceDommageService
    {
        Task<IEnumerable<AssuranceDommage>> GetAllWithFiche();
        Task<AssuranceDommage> GetAssuranceDommageById(int id);
        Task<IEnumerable<AssuranceDommage>> GetAssurancesDommageByFicheId(int ficheId);
        Task<AssuranceDommage> CreateAssuranceDommage(AssuranceDommage newAssuranceDommage);
        Task UpdateAssuranceDommage(AssuranceDommage assuranceDommageToBeUpdated, AssuranceDommage assuranceDommage);
        Task DeleteAssuranceDommage(AssuranceDommage assuranceDommage);
    }
}
