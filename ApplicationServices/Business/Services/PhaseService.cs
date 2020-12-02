using ApplicationServices;
using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class PhaseService : IPhaseService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PhaseService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Phases> CreatePhase(Phases newPhase)
        {
            await _unitOfWork.Phases.AddAsync(newPhase);
            await _unitOfWork.CommitAsync();
            return newPhase;
        }

        public async Task DeletePhase(Phases phase)
        {
            _unitOfWork.Phases.Remove(phase);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Phases> GetPhaseById(int id)
        {
            return await _unitOfWork.Phases.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Phases>> GetPhaseByFicheId(int ficheId)
        {
            return await _unitOfWork.Phases.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<Phases>> GetAllWithFiche()
        {
            return await _unitOfWork.Phases.GetAllWithFichesAsync();
        }

        public async Task UpdatePhase(Phases phaseToBeUpdated, Phases phase)
        {
            phaseToBeUpdated.PhaseContact = phase.PhaseContact;
            phaseToBeUpdated.PhaseDecouverte = phase.PhaseDecouverte;
            phaseToBeUpdated.PhaseTransition = phase.PhaseTransition;
            phaseToBeUpdated.PhaseVente = phase.PhaseVente;
            phaseToBeUpdated.PhaseConclusion = phase.PhaseConclusion;
            phaseToBeUpdated.PhaseAsseoirVente = phase.PhaseAsseoirVente;
            phaseToBeUpdated.PhasePriseConge = phase.PhasePriseConge;

            await _unitOfWork.CommitAsync();
        }
    }
}

/*        public string PhaseContact { get; set; }
        public string PhaseDecouverte { get; set; }
        public string PhaseTransition { get; set; }
        public string PhaseVente { get; set; }
        public string PhaseConclusion { get; set; }
        public string PhaseAsseoirVente { get; set; }
        public string PhasePriseConge { get; set; }*/