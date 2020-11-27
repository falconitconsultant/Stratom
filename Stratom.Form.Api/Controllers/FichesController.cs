using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Data;
using Stratom.Form.Core.ViewModel;

namespace Stratom.Form.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichesController : ControllerBase
    {
        //StratomFormDbContext _context = new StratomFormDbContext();
        private readonly IUnitOfWork _unitOfWork;
        public FichesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: api/Fiches
        [HttpGet]
        public async Task<ActionResult> GetDocuments(string id)
        {
            try
            {
                MainViewModel model = new MainViewModel();
                if (id != null)
                {
                    //IEnumerable<Fiche> fiche;// = new IEnumerable<Fiche>();

                    model.fiche = await _unitOfWork.Fiches.GetAllFichesByStudentId(id);
                    model.activite = model.fiche.Activites.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.activiteType = model.fiche.ActiviteTypes.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.assuranceDommage = model.fiche.AssurancesDommage.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.assurancePersonne = model.fiche.AssurancesPersonne.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.concerne = model.fiche.Concernes.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.contratsPortefeuille = model.fiche.ContratsPortefeuilles.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.descriptionActivite = model.fiche.DescriptionsActivite.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.ficheClientProspect = model.fiche.FichesClientProspect.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.ficheContexteSimplifiee = model.fiche.FichesContexteSimplifiee.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.ficheFin = model.fiche.FichesFin.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                    model.phase = model.fiche.Phases.Where(x => x.FicheId == model.fiche.Id).FirstOrDefault();
                }
                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }

        // GET: api/Fiches/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        //[Route("api/Employee/Update")]
        //[HttpPost]
        [HttpPost("[action]")]
        public void Update([FromBody] MainViewModel model)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.ActiviteTypes.Update(model.activiteType);
                _unitOfWork.AssurancesDommage.Update(model.assuranceDommage);
                _unitOfWork.AssurancesPersonne.Update(model.assurancePersonne);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
                _unitOfWork.Activites.Update(model.activite);
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
