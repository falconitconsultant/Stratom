using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IAssurancePersonneService
    {
        Task<IEnumerable<AssurancePersonne>> GetAllWithFiche();
        Task<AssurancePersonne> GetAssurancePersonneById(int id);
        Task<IEnumerable<AssurancePersonne>> GetAssurancesPersonneByFicheId(int ficheId);
        Task<AssurancePersonne> CreateAssurancePersonne(AssurancePersonne newAssurancePersonne);
        Task UpdateAssurancePersonne(AssurancePersonne assurancePersonneToBeUpdated, AssurancePersonne assurancePersonne);
        Task DeleteAssurancePersonne(AssurancePersonne assurancePersonne);
    }
}
