using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IDescriptionActiviteService
    {
        Task<IEnumerable<DescriptionsActivite>> GetAllWithFiche();
        Task<DescriptionsActivite> GetDescriptionActiviteById(int id);
        Task<IEnumerable<DescriptionsActivite>> GetDescriptionsActiviteByFicheId(int ficheId);
        Task<DescriptionsActivite> CreateDescriptionActivite(DescriptionsActivite newDescriptionActivite);
        Task UpdateDescriptionActivite(DescriptionsActivite descriptionActiviteToBeUpdated, DescriptionsActivite descriptionActivite);
        Task DeleteDescriptionActivite(DescriptionsActivite descriptionActivite);
    }
}
