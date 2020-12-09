using ApplicationServices.Business.AppServices.IAppServices;
using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Business.AppServices
{
    public class FicheRepository : Repository<Fiches>, IFicheRepository
    {
        private readonly StratomContext _context;
        private readonly HttpClient _httpClient;
        //public FicheRepository(StratomContext context, HttpClient httpClient)
        //{
        //    _context = context;
        //    this._httpClient = httpClient;
        //}
        public FicheRepository(StratomContext context)
    : base(context)
        {
            _context = context;
        }
        private StratomContext StratomContext
        {
            get { return Context as StratomContext; }
        }
        public async Task<MainViewModel> GetAllFichesInViewModel(string id)
        {
            //MainViewModel model = new MainViewModel();
            //Fiche fiche = await _unitOfWork.Fiches.GetAllFichesByStudentId(id);
            //model.fiche = fiche;
            //return model;
            return await _httpClient.GetJsonAsync<MainViewModel>("api/Fiches/?id=" + id);/*_httpClient.GetJsonAsync<MainViewModel>("api/Fiches/?id=" + id);*/
        }
        public async Task<IEnumerable<Fiches>> GetAllByEtudiantIdAsync(int etudiantId)
        {
            return await StratomContext.Fiches
                .Include(m => m.Activites)
                .Include(m => m.ActiviteType)
                //.Include(m => m.AssurancesDommage)
                //.Include(m => m.AssurancesPersonne)
                .Include(m => m.Concernes)
                .Include(m => m.ContratsPortefeuilles)
                .Include(m => m.DescriptionsActivite)
                .Include(m => m.FichesClientProspect)
                .Include(m => m.FichesContexteSimplifiee)
                .Include(m => m.FichesFin)
                .Include(m => m.Phases)
                .Include(m => m.ApplicationUser)
                .ToListAsync();
        }

        public async Task<Fiches> GetAllByIdAsync(int id)
        {
            return await StratomContext.Fiches
                .Include(m => m.Activites)
                .Include(m => m.ActiviteType)
                //.Include(m => m.AssurancesDommage)
                //.Include(m => m.AssurancesPersonne)
                .Include(m => m.Concernes)
                .Include(m => m.ContratsPortefeuilles)
                .Include(m => m.DescriptionsActivite)
                .Include(m => m.FichesClientProspect)
                .Include(m => m.FichesContexteSimplifiee)
                .Include(m => m.FichesFin)
                .Include(m => m.Phases)
                .SingleOrDefaultAsync(m => m.Id == id);
        }

        //public async Task<Fiches> GetAllFichesByStudentId(string id)
        //{
        //    try
        //    {
        //        return await StratomContext.Fiches.SingleOrDefaultAsync(m => m.StudentId == id);
        //        //return await StratomContext.Fiches
        //        //.Include(m => m.Activites)
        //        //.Include(m => m.ActiviteType)
        //        ////.Include(m => m.AssurancesDommage)
        //        ////.Include(m => m.AssurancesPersonne)
        //        //.Include(m => m.Concernes)
        //        //.Include(m => m.ContratsPortefeuilles)
        //        //.Include(m => m.DescriptionsActivite)
        //        //.Include(m => m.FichesClientProspect)
        //        //.Include(m => m.FichesContexteSimplifiee)
        //        //.Include(m => m.FichesFin)
        //        //.Include(m => m.Phases)
        //        //.SingleOrDefaultAsync(m => m.StudentId == id);
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }

        //}
        public async Task<Fiches> GetAllByNumeroFicheAsync(int etudiantId, int numeroFiche)
        {
            return await StratomContext.Fiches
                .Include(m => m.Activites)
                .Include(m => m.ActiviteType)
                //.Include(m => m.AssurancesDommage)
                //.Include(m => m.AssurancesPersonne)
                .Include(m => m.Concernes)
                .Include(m => m.ContratsPortefeuilles)
                .Include(m => m.DescriptionsActivite)
                .Include(m => m.FichesClientProspect)
                .Include(m => m.FichesContexteSimplifiee)
                .Include(m => m.FichesFin)
                .Include(m => m.Phases)
                .SingleOrDefaultAsync(m => m.NumeroFiche == numeroFiche);
        }

        public async Task<IEnumerable<Fiches>> GetAllFichesAsync()
        {
            return await StratomContext.Fiches
                .Include(m => m.Activites)
                .Include(m => m.ActiviteType)
                //.Include(m => m.AssurancesDommage)
                //.Include(m => m.AssurancesPersonne)
                .Include(m => m.Concernes)
                .Include(m => m.ContratsPortefeuilles)
                .Include(m => m.DescriptionsActivite)
                .Include(m => m.FichesClientProspect)
                .Include(m => m.FichesContexteSimplifiee)
                .Include(m => m.FichesFin)
                .Include(m => m.Phases)
                .ToListAsync();
        }

        public void Update(Fiches fiche)
        {
            var objFromDb = StratomContext.Fiches.FirstOrDefault(c => c.Id == fiche.Id);
            objFromDb.NumeroFiche = fiche.NumeroFiche;
            StratomContext.SaveChanges();
        }
        public int Add(Fiches fiche)
        {
            StratomContext.Fiches.Add(fiche);
            StratomContext.SaveChanges();
            return fiche.Id;
        }

        public async Task<IEnumerable<Fiches>> GetAllFichesByStudentId(string id)
        {
            return await StratomContext.Fiches.Where(m => m.StudentId == id).ToListAsync();//return await _httpClient.GetJsonAsync<IEnumerable<Fiches>>("api/Fiches/?id=" + id);
        }
    }
}
