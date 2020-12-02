using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services
{
    public class FicheClientProspectService : IFicheClientProspectService
    {
        private readonly IUnitOfWork _unitOfWork;
        public FicheClientProspectService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<FichesClientProspect> CreateFicheClientProspect(FichesClientProspect newFicheClientProspect)
        {
            await _unitOfWork.FichesClientProspect.AddAsync(newFicheClientProspect);
            await _unitOfWork.CommitAsync();
            return newFicheClientProspect;
        }

        public async Task DeleteFicheClientProspect(FichesClientProspect ficheClientProspect)
        {
            _unitOfWork.FichesClientProspect.Remove(ficheClientProspect);
            await _unitOfWork.CommitAsync();
        }

        public async Task<FichesClientProspect> GetFicheClientProspectById(int id)
        {
            return await _unitOfWork.FichesClientProspect.GetByIdAsync(id);
        }

        public async Task<IEnumerable<FichesClientProspect>> GetFicheClientProspectByFicheId(int ficheId)
        {
            return await _unitOfWork.FichesClientProspect.GetAllWithFicheByFicheIdAsync(ficheId);
        }

        public async Task<IEnumerable<FichesClientProspect>> GetAllWithFiche()
        {
            return await _unitOfWork.FichesClientProspect.GetAllWithFichesAsync();
        }

        public async Task UpdateFicheClientProspect(FichesClientProspect ficheClientProspectToBeUpdated, FichesClientProspect ficheClientProspect)
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