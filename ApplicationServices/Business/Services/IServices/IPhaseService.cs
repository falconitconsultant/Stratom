using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IPhaseService
    {
        Task<IEnumerable<Phases>> GetAllWithFiche();
        Task<Phases> GetPhaseById(int id);
        Task<IEnumerable<Phases>> GetPhaseByFicheId(int ficheId);
        Task<Phases> CreatePhase(Phases newPhase);
        Task UpdatePhase(Phases phaseToBeUpdated, Phases phase);
        Task DeletePhase(Phases phase);
    }
}
