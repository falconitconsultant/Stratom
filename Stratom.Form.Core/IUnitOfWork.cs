using Stratom.Form.Core.Repositories;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core
{
    public interface IUnitOfWork : IDisposable
    {
        #region Repository
        IFicheRepository Fiches { get; }
        IActiviteTypeRepository ActiviteTypes { get; }
        IConcerneRepository Concernes { get; }
        IActiviteRepository Activites { get; }
        IAssurancePersonneRepository AssurancesPersonne { get; }
        IAssuranceDommageRepository AssurancesDommage { get; }
        IFicheClientProspectRepository FichesClientProspect { get; }
        IDescriptionActiviteRepository DescriptionsActivite { get; }
        IFicheContexteSimplifieeRepository FichesContexteSimplifiee { get; }
        IContratsPortefeuilleRepository ContratsPortefeuilles { get; }
        IPhaseRepository Phases { get; }
        IFicheFinRepository FichesFin { get; }
        #endregion

        //#region Services
        //IFicheService FichesServices { get; }
        //IActiviteTypeService ActiviteTypesService { get; }
        //IConcerneService ConcernesService { get; }
        //IActiviteService ActivitesService { get; }
        //IAssurancePersonneService AssurancesPersonneService { get; }
        //IAssuranceDommageService AssurancesDommageService { get; }
        //IFicheClientProspectService FichesClientProspectService { get; }
        //IDescriptionActiviteService DescriptionsActiviteService { get; }
        //IFicheContexteSimplifieeService FichesContexteSimplifieeService { get; }
        //IContratsPortefeuilleService ContratsPortefeuillesService { get; }
        //IPhaseService PhasesService { get; }
        //IFicheFinService FichesFinService { get; }
        //#endregion

        Task<int> CommitAsync();
    }
}
