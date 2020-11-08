using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IPhaseService
    {
        Task<IEnumerable<Phase>> GetAllWithFiche();
        Task<Phase> GetPhaseById(int id);
        Task<IEnumerable<Phase>> GetPhaseByFicheId(int ficheId);
        Task<Phase> CreatePhase(Phase newPhase);
        Task UpdatePhase(Phase phaseToBeUpdated, Phase phase);
        Task DeletePhase(Phase phase);
    }
}
