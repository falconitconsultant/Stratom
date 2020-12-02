using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IConcerneService
    {
        Task<IEnumerable<Concernes>> GetAllWithFiche();
        Task<Concernes> GetConcerneById(int id);
        Task<IEnumerable<Concernes>> GetConcernesByFicheId(int ficheId);
        Task<Concernes> CreateConcerne(Concernes newConcerne);
        Task UpdateConcerne(Concernes concerneToBeUpdated, Concernes concerne);
        Task DeleteConcerne(Concernes concerne);
    }
}
