using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Repositories
{
    public interface IFicheRepository : IRepository<Fiche>
    {
        Task<IEnumerable<Fiche>> GetAllFichesAsync();
        Task<Fiche> GetAllByIdAsync(int id);
        Task<Fiche> GetAllByNumeroFicheAsync(int etudiantId, int numeroFiche);
        Task<IEnumerable<Fiche>> GetAllByEtudiantIdAsync(int etudiantId);

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
