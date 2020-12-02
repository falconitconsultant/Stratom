using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationServices;
using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StratomApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FichesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/Fiches
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Fiches/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [HttpGet]
        public async Task<ActionResult> GetDocuments(string id)
        {
            try
            {
                MainViewModel model = new MainViewModel();
                if (id != null)
                {
                    IEnumerable<Fiches> fiche;// = new IEnumerable<Fiche>();
                    model.fiche = await _unitOfWork.Fiches.GetAllFichesByStudentId(id);
                    model.activiteType = await _unitOfWork.ActiviteTypes.GetAllAsync();
                    model.concerne = await _unitOfWork.Concernes.GetAllAsync();
                    model.activite = await _unitOfWork.Activites.GetAllAsync();
                    model.assurancePersonne = await _unitOfWork.AssurancesPersonne.GetAllAsync();
                    model.assuranceDommage = await _unitOfWork.AssurancesDommage.GetAllAsync();
                    //usr = await _unitOfWork.applicationUser.GetAllByStudentId(id);
                    //model.Nom = usr.Nom;
                    //model.Prenom = usr.Prenom;
                    //model.activite = model.fiche.Activites.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.activiteType = model.fiche.ActiviteTypes.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.assuranceDommage = model.fiche.AssurancesDommage.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.assurancePersonne = model.fiche.AssurancesPersonne.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.concerne = model.fiche.Concernes.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.activiteType = model.activiteType;
                    //Working Code Below
                    //model.contratsPortefeuille = model.fiche.ContratsPortefeuilles.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.descriptionActivite = model.fiche.DescriptionsActivite.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.ficheClientProspect = model.fiche.FichesClientProspect.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.ficheContexteSimplifiee = model.fiche.FichesContexteSimplifiee.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.ficheFin = model.fiche.FichesFin.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    //model.phase = model.fiche.Phases.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                }
                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        [HttpPut("{id}")]//[HttpPut("{id}")]
        public void Update(int id, [FromBody] MainViewModel model)
        {
            if (ModelState.IsValid)
            {
                //_unitOfWork.Activites.Update(model.activite);
                //_unitOfWork.ActiviteTypes.Update(model.activiteType);
                //_unitOfWork.AssurancesDommage.Update(model.assuranceDommage);
                //_unitOfWork.AssurancesPersonne.Update(model.assurancePersonne);
                //_unitOfWork.Concernes.Update(model.concerne);
                _unitOfWork.ContratsPortefeuilles.Update(model.contratsPortefeuille);
                _unitOfWork.DescriptionsActivite.Update(model.descriptionActivite);
                _unitOfWork.Fiches.Update(model.fiche);
                _unitOfWork.FichesClientProspect.Update(model.ficheClientProspect);
                _unitOfWork.FichesContexteSimplifiee.Update(model.ficheContexteSimplifiee);
                _unitOfWork.FichesFin.Update(model.ficheFin);
                _unitOfWork.Phases.Update(model.phase);
                _unitOfWork.CommitAsync();
            }
        }
        // POST: api/Fiches
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Fiches/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
