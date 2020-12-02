using Domain.Entities;
using Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices.IAppServices
{
    public interface IFicheRepository : IRepository<Fiches>
    {
        Task<IEnumerable<Fiches>> GetAllFichesAsync();
        Task<Fiches> GetAllByIdAsync(int id);
        Task<MainViewModel> GetAllFichesInViewModel(string id);
        Task<Fiches> GetAllFichesByStudentId(string id);
        Task<Fiches> GetAllByNumeroFicheAsync(int etudiantId, int numeroFiche);
        Task<IEnumerable<Fiches>> GetAllByEtudiantIdAsync(int etudiantId);
        void Update(Fiches fiche);
        //Not needed atm
        //Task<IEnumerable<Fiche>> GetAllByActiviteTypeIdAsync(int activiteTypeId);
        //Task<IEnumerable<Fiche>> GetAllByConcerneIdAsync(int concerneId);
        //Task<IEnumerable<Fiche>> GetAllByActiviteIdAsync(int activiteId);
        //Task<IEnumerable<Fiche>> GetAllByAssurancePersonneIdAsync(int assurancePersonneId);
        //Task<IEnumerable<Fiche>> GetAllByAssuranceDommageIdAsync(int assuranceDommageId);
        //Task<IEnumerable<Fiche>> GetAllByFicheClientProspectIdAsync(int ficheClientProspectId);
        //Task<IEnumerable<Fiche>> GetAllByDescriptionActiviteIdAsync(int descriptionActiviteId);
        //Task<IEnumerable<Fiche>> GetAllByFicheContexteSimplifieeIdAsync(int ficheContexteSimplifieeId);
        //Task<IEnumerable<Fiche>> GetAllByContratsPortefeuilleIdAsync(int contratsPortefeuilleId);
        //Task<IEnumerable<Fiche>> GetAllByPhaseIdAsync(int phaseId);
        //Task<IEnumerable<Fiche>> GetAllByFicheFinIdAsync(int ficheFinId);
    }
}
