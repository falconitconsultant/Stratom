using Stratom.Form.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IFicheRepository Fiches { get; }
        IEtudiantRepository Etudiants { get; }
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

        Task<int> CommitAsync();
    }
}
