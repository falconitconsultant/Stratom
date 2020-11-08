using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IFicheFinService
    {
        Task<IEnumerable<FicheFin>> GetAllWithFiche();
        Task<FicheFin> GetFicheFinById(int id);
        Task<IEnumerable<FicheFin>> GetFicheFinByFicheId(int ficheId);
        Task<FicheFin> CreateFicheFin(FicheFin newFicheFin);
        Task UpdateFicheFin(FicheFin ficheFinToBeUpdated, FicheFin ficheFin);
        Task DeleteFicheFin(FicheFin ficheFin);
    }
}
