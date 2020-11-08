using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Stratom.Form.Services.Services
{
    public class FicheClientProspectService : IFicheClientProspectService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FicheClientProspectService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<FicheClientProspect> CreateFicheClientProspect(FicheClientProspect newFicheClientProspect)
        {
            await _unitOfWork.FichesClientProspect.AddAsync(newFicheClientProspect);
            await _unitOfWork.CommitAsync();
            return newFicheClientProspect;
        }

        public async Task DeleteFicheClientProspect(FicheClientProspect ficheClientProspect)
        {
            _unitOfWork.FichesClientProspect.Remove(ficheClientProspect);
            await _unitOfWork.CommitAsync();
        }

        public async Task<FicheClientProspect> GetFicheClientProspectById(int id)
        {
            return await _unitOfWork.FichesClientProspect.GetByIdAsync(id);
        }

        public async Task<IEnumerable<FicheClientProspect>> GetFicheClientProspectByFicheId(int ficheId)
        {
            return await _unitOfWork.FichesClientProspect.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<FicheClientProspect>> GetAllWithFiche()
        {
            return await _unitOfWork.FichesClientProspect.GetAllWithFichesAsync();
        }

        public async Task UpdateFicheClientProspect(FicheClientProspect ficheClientProspectToBeUpdated, FicheClientProspect ficheClientProspect)
        {
            ficheClientProspectToBeUpdated.Nom = ficheClientProspect.Nom;
            ficheClientProspectToBeUpdated.Prenom = ficheClientProspect.Prenom;
            ficheClientProspectToBeUpdated.Sexe = ficheClientProspect.Sexe;
            ficheClientProspectToBeUpdated.Age = ficheClientProspect.Age;
            ficheClientProspectToBeUpdated.Adresse = ficheClientProspect.Adresse;
            ficheClientProspectToBeUpdated.CodePostal = ficheClientProspect.CodePostal;
            ficheClientProspectToBeUpdated.Ville = ficheClientProspect.Ville;
            ficheClientProspectToBeUpdated.Telephone = ficheClientProspect.Telephone;
            ficheClientProspectToBeUpdated.Mobile = ficheClientProspect.Mobile;
            ficheClientProspectToBeUpdated.Mail = ficheClientProspect.Mail;
            ficheClientProspectToBeUpdated.Autre = ficheClientProspect.Autre;
            ficheClientProspectToBeUpdated.SituationFamiliale = ficheClientProspect.SituationFamiliale;
            ficheClientProspectToBeUpdated.NbEnfants = ficheClientProspect.NbEnfants;
            ficheClientProspectToBeUpdated.AgesEnfants = ficheClientProspect.AgesEnfants;
            ficheClientProspectToBeUpdated.SituationProfessionnelle = ficheClientProspect.SituationProfessionnelle;
            ficheClientProspectToBeUpdated.IsClient = ficheClientProspect.IsClient;
            ficheClientProspectToBeUpdated.Statut = ficheClientProspect.Statut;
            ficheClientProspectToBeUpdated.Anciennete = ficheClientProspect.Anciennete;
            ficheClientProspectToBeUpdated.Revenus = ficheClientProspect.Revenus;
            ficheClientProspectToBeUpdated.TauxImposition = ficheClientProspect.TauxImposition;
            ficheClientProspectToBeUpdated.Placements = ficheClientProspect.Placements;

            await _unitOfWork.CommitAsync();
        }
    }
}