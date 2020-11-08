using Stratom.Form.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Core.Services
{
    public interface IEtudiantService
    {
        Task<IEnumerable<Etudiant>> GetAllWithFiche();
        Task<Etudiant> GetEtudiantById(int id);
        Task<IEnumerable<Etudiant>> GetEtudiantByFicheId(int ficheId);
        Task<Etudiant> CreateEtudiant(Etudiant newEtudiant);
        Task UpdateEtudiant(Etudiant etudiantToBeUpdated, Etudiant etudiant);
        Task DeleteEtudiant(Etudiant etudiant);
    }
}
