using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IAssurancePersonneService
    {
        //Task<IEnumerable<AssurancePersonne>> GetAllWithFiche();
        Task<AssurancesPersonne> GetAssurancePersonneById(int id);
        //Task<IEnumerable<AssurancePersonne>> GetAssurancesPersonneByFicheId(int ficheId);
        Task<AssurancesPersonne> CreateAssurancePersonne(AssurancesPersonne newAssurancePersonne);
        Task UpdateAssurancePersonne(AssurancesPersonne assurancePersonneToBeUpdated, AssurancesPersonne assurancePersonne);
        Task DeleteAssurancePersonne(AssurancesPersonne assurancePersonne);
    }
}
