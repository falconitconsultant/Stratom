using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IActiviteTypeRepository : IRepository<ActiviteTypes>
    {
        Task<IEnumerable<ActiviteTypes>> GetAllWithFichesAsync();
        Task<ActiviteTypes> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<ActiviteTypes>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(ActiviteTypes activiteType);
    }
}
