using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IContratsPortefeuilleService
    {
        Task<IEnumerable<ContratsPortefeuille>> GetAllWithFiche();
        Task<ContratsPortefeuille> GetContratsPortefeuilleById(int id);
        Task<IEnumerable<ContratsPortefeuille>> GetContratsPortefeuilleByFicheId(int ficheId);
        Task<ContratsPortefeuille> CreateContratsPortefeuille(ContratsPortefeuille newContratsPortefeuille);
        Task UpdateContratsPortefeuille(ContratsPortefeuille contratsPortefeuilleToBeUpdated, ContratsPortefeuille contratsPortefeuille);
        Task DeleteContratsPortefeuille(ContratsPortefeuille contratsPortefeuille);
    }
}
