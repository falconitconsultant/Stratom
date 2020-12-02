using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IAssuranceDommageService
    {
        //Task<IEnumerable<AssuranceDommage>> GetAllWithFiche();
        Task<AssurancesDommage> GetAssuranceDommageById(int id);
        //Task<IEnumerable<AssuranceDommage>> GetAssurancesDommageByFicheId(int ficheId);
        Task<AssurancesDommage> CreateAssuranceDommage(AssurancesDommage newAssuranceDommage);
        Task UpdateAssuranceDommage(AssurancesDommage assuranceDommageToBeUpdated, AssurancesDommage assuranceDommage);
        Task DeleteAssuranceDommage(AssurancesDommage assuranceDommage);
    }
}
