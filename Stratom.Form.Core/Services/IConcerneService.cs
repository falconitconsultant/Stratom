using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IConcerneService
    {
        Task<IEnumerable<Concerne>> GetAllWithFiche();
        Task<Concerne> GetConcerneById(int id);
        Task<IEnumerable<Concerne>> GetConcernesByFicheId(int ficheId);
        Task<Concerne> CreateConcerne(Concerne newConcerne);
        Task UpdateConcerne(Concerne concerneToBeUpdated, Concerne concerne);
        Task DeleteConcerne(Concerne concerne);
    }
}
