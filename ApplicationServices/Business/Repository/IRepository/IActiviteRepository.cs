using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IActiviteRepository : IRepository<Activites>
    {
        //Task<IEnumerable<Activite>> GetAllWithFichesAsync();
        //Task<Activite> GetWithFichesByIdAsync(int id);
        //Task<IEnumerable<Activite>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(Activites activite);
    }
}
