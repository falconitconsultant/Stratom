using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IContratsPortefeuilleService
    {
        Task<IEnumerable<ContratsPortefeuilles>> GetAllWithFiche();
        Task<ContratsPortefeuilles> GetContratsPortefeuilleById(int id);
        Task<IEnumerable<ContratsPortefeuilles>> GetContratsPortefeuilleByFicheId(int ficheId);
        Task<ContratsPortefeuilles> CreateContratsPortefeuille(ContratsPortefeuilles newContratsPortefeuille);
        Task UpdateContratsPortefeuille(ContratsPortefeuilles contratsPortefeuilleToBeUpdated, ContratsPortefeuilles contratsPortefeuille);
        Task DeleteContratsPortefeuille(ContratsPortefeuilles contratsPortefeuille);
    }
}
