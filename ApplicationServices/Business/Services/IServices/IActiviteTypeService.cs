using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IActiviteTypeService
    {
        Task<IEnumerable<ActiviteTypes>> GetAllWithFiche();
        Task<ActiviteTypes> GetActiviteTypeById(int id);
        Task<IEnumerable<ActiviteTypes>> GetActiviteTypesByFicheId(int ficheId);
        Task<ActiviteTypes> CreateActiviteType(ActiviteTypes newActiviteType);
        Task UpdateActiviteType(ActiviteTypes activiteTypeToBeUpdated, ActiviteTypes activiteType);
        Task DeleteActiviteType(ActiviteTypes activiteType);
    }
}
