using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IDescriptionActiviteRepository : IRepository<DescriptionsActivite>
    {
        Task<IEnumerable<DescriptionsActivite>> GetAllWithFichesAsync();
        Task<DescriptionsActivite> GetWithFichesByIdAsync(int id);
        Task<IEnumerable<DescriptionsActivite>> GetAllWithFicheByFicheIdAsync(int ficheId);
        void Update(DescriptionsActivite descriptionActivite);
        void Add(DescriptionsActivite descriptionActivite);
    }
}
