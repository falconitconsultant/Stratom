using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class EtudiantService : IEtudiantService
    {
        private readonly IUnitOfWork _unitOfWork;
        public EtudiantService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Etudiant> CreateEtudiant(Etudiant newEtudiant)
        {
            await _unitOfWork.Etudiants.AddAsync(newEtudiant);
            await _unitOfWork.CommitAsync();
            return newEtudiant;
        }

        public async Task DeleteEtudiant(Etudiant etudiant)
        {
            _unitOfWork.Etudiants.Remove(etudiant);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Etudiant> GetEtudiantById(int id)
        {
            return await _unitOfWork.Etudiants.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Etudiant>> GetEtudiantByFicheId(int ficheId)
        {
            return await _unitOfWork.Etudiants.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<Etudiant>> GetAllWithFiche()
        {
            return await _unitOfWork.Etudiants.GetAllWithFichesAsync();
        }

        public async Task UpdateEtudiant(Etudiant etudiantToBeUpdated, Etudiant etudiant)
        {
            etudiantToBeUpdated.Nom = etudiant.Nom;
            etudiantToBeUpdated.Prenom = etudiant.Prenom;

            await _unitOfWork.CommitAsync();
        }
    }
}
