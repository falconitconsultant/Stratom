using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IAssurancePersonneRepository : IRepository<AssurancesPersonne>
    {
        //Task<IEnumerable<AssurancePersonne>> GetAllWithFichesAsync();
        //Task<AssurancePersonne> GetWithFichesByIdAsync(int id);
        //Task<IEnumerable<AssurancePersonne>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(AssurancesPersonne assurancePersonne);
    }
}
