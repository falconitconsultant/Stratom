﻿using ApplicationServices.Business.Services.IServices;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.Services
{
    public class ActiviteService : IActiviteService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ActiviteService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Activites> CreateActivite(Activites newActivite)
        {
            await _unitOfWork.Activites.AddAsync(newActivite);
            await _unitOfWork.CommitAsync();
            return newActivite;
        }

        public async Task DeleteActivite(Activites activite)
        {
            _unitOfWork.Activites.Remove(activite);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Activites> GetActiviteById(int id)
        {
            return await _unitOfWork.Activites.GetByIdAsync(id);
        }

        //public async Task<IEnumerable<Activite>> GetActivitesByFicheId(int ficheId)
        //{
        //    return await _unitOfWork.Activites.GetAllWithFicheByFicheIdAsync(ficheId);
        //}

        //public async Task<IEnumerable<Activite>> GetAllWithFiche()
        //{
        //    return await _unitOfWork.Activites.GetAllWithFichesAsync();
        //}

        public async Task UpdateActivite(Activites activiteToBeUpdated, Activites activite)
        {
            activiteToBeUpdated.Souscription = activite.Souscription;
            activiteToBeUpdated.Autre = activite.Autre;

            await _unitOfWork.CommitAsync();
        }
    }
}
