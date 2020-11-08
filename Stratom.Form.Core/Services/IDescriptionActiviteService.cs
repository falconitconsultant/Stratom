using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IDescriptionActiviteService
    {
        Task<IEnumerable<DescriptionActivite>> GetAllWithFiche();
        Task<DescriptionActivite> GetDescriptionActiviteById(int id);
        Task<IEnumerable<DescriptionActivite>> GetDescriptionsActiviteByFicheId(int ficheId);
        Task<DescriptionActivite> CreateDescriptionActivite(DescriptionActivite newDescriptionActivite);
        Task UpdateDescriptionActivite(DescriptionActivite descriptionActiviteToBeUpdated, DescriptionActivite descriptionActivite);
        Task DeleteDescriptionActivite(DescriptionActivite descriptionActivite);
    }
}
