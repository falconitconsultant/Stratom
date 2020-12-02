using ApplicationServices.Business.AppServices;
using ApplicationServices.Business.AppServices.IAppServices;
using ApplicationServices.Business.Repository;
using Domain.Entities;
using Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StratomContext _context;
        private FicheRepository _ficheRepository;
        private ActiviteTypeRepository _activiteTypeRepository;
        private ConcerneRepository _concerneRepository;
        private ActiviteRepository _activiteRepository;
        private AssurancePersonneRepository _assurancePersonneRepository;
        private AssuranceDommageRepository _assuranceDommageRepository;
        private FicheClientProspectRepository _ficheClientProspectRepository;
        private DescriptionActiviteRepository _descriptionActiviteRepository;
        private FicheContexteSimplifieeRepository _ficheContexteSimplifieeRepository;
        private ContratsPortefeuilleRepository _contratsPortefeuilleRepository;
        private PhaseRepository _phaseRepository;
        private FicheFinRepository _ficheFinRepository;
        private ApplicationUserRepository _applicationUserRepository;
        public UnitOfWork(StratomContext context)
        {
            this._context = context;
        }

        public IFicheRepository Fiches => _ficheRepository ??= new FicheRepository(_context);

        public IActiviteTypeRepository ActiviteTypes => _activiteTypeRepository ??= new ActiviteTypeRepository(_context);

        public IConcerneRepository Concernes => _concerneRepository ??= new ConcerneRepository(_context);

        public IActiviteRepository Activites => _activiteRepository ??= new ActiviteRepository(_context);

        public IAssurancePersonneRepository AssurancesPersonne => _assurancePersonneRepository ??= new AssurancePersonneRepository(_context);

        public IAssuranceDommageRepository AssurancesDommage => _assuranceDommageRepository ??= new AssuranceDommageRepository(_context);

        public IFicheClientProspectRepository FichesClientProspect => _ficheClientProspectRepository ??= new FicheClientProspectRepository(_context);

        public IDescriptionActiviteRepository DescriptionsActivite => _descriptionActiviteRepository ??= new DescriptionActiviteRepository(_context);

        public IFicheContexteSimplifieeRepository FichesContexteSimplifiee => _ficheContexteSimplifieeRepository ??= new FicheContexteSimplifieeRepository(_context);

        public IContratsPortefeuilleRepository ContratsPortefeuilles => _contratsPortefeuilleRepository ??= new ContratsPortefeuilleRepository(_context);

        public IPhaseRepository Phases => _phaseRepository ??= new PhaseRepository(_context);

        public IFicheFinRepository FichesFin => _ficheFinRepository ??= new FicheFinRepository(_context);

        public IApplicationUserRepository applicationUser => _applicationUserRepository ??= new ApplicationUserRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        //Task<int> IUnitOfWork.CommitAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
