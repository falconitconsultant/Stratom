using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services.IServices
{
    public interface IActiviteService
    {
        //Task<IEnumerable<Activite>> GetAllWithFiche();
        Task<Activites> GetActiviteById(int id);
        //Task<IEnumerable<Activite>> GetActivitesByFicheId(int ficheId);
        Task<Activites> CreateActivite(Activites newActivite);
        Task UpdateActivite(Activites activiteToBeUpdated, Activites activite);
        Task DeleteActivite(Activites activite);
    }
}
