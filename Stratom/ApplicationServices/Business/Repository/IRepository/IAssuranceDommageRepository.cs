using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IAssuranceDommageRepository : IRepository<AssurancesDommage>
    {
        //Task<IEnumerable<AssuranceDommage>> GetAllWithFichesAsync();
        //Task<AssuranceDommage> GetWithFichesByIdAsync(int id);
        //Task<IEnumerable<AssuranceDommage>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(AssurancesDommage assuranceDommage);
    }
}
