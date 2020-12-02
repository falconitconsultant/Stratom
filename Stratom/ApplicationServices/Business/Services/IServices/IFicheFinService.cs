using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IFicheFinService
    {
        Task<IEnumerable<FichesFin>> GetAllWithFiche();
        Task<FichesFin> GetFicheFinById(int id);
        Task<IEnumerable<FichesFin>> GetFicheFinByFicheId(int ficheId);
        Task<FichesFin> CreateFicheFin(FichesFin newFicheFin);
        Task UpdateFicheFin(FichesFin ficheFinToBeUpdated, FichesFin ficheFin);
        Task DeleteFicheFin(FichesFin ficheFin);
    }
}
