using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using ApplicationServices;
using DinkToPdf;
using DinkToPdf.Contracts;
using Domain.Entities;
using Domain.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SelectPdf;
using StratomApi.Utility;

namespace StratomApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private IConverter _converter;
        public FichesController(IUnitOfWork unitOfWork, IConverter converter)//,IServiceCollection services)
        {
            try
            {
                _unitOfWork = unitOfWork;

                //string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\libwkhtmltox.dll";
                //CustomAssemblyLoadContext context = new CustomAssemblyLoadContext();
                //context.LoadUnmanagedLibrary(filePath);
                //services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

                //_converter = new SynchronizedConverter(new PdfTools());
                _converter = converter;
            }
            catch (Exception ex)
            {

            }
//
        }
        [HttpGet]
        public async Task<ActionResult> GetDocuments(string id)
        {
            try
            {
                MainViewModel model = new MainViewModel();
                if (id != null)
                {
                    IEnumerable<Fiches> fiche;// = new IEnumerable<Fiche>();
                    //model.fiche = await _unitOfWork.Fiches.GetAllFichesByStudentId(id);
                    model.activiteType = await _unitOfWork.ActiviteTypes.GetAllAsync();
                    model.concerne = await _unitOfWork.Concernes.GetAllAsync();
                    model.activite = await _unitOfWork.Activites.GetAllAsync();
                    model.assurancePersonne = await _unitOfWork.AssurancesPersonne.GetAllAsync();
                    model.assuranceDommage = await _unitOfWork.AssurancesDommage.GetAllAsync();

                }
                return Ok(model);
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        [HttpGet]
        [Route("GetAllDocuments/{StudentId}")]
        public async Task<ActionResult> GetAllDocuments(string StudentId)//
        {
            try
            {
                IEnumerable<Fiches> fiche;
                fiche = await _unitOfWork.Fiches.GetAllFichesByStudentId(StudentId);
                return Ok(fiche);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }
        [HttpGet]
        [Route("GetDocumentById/{id}")]
        public async Task<ActionResult> GetDocumentById(int id)
        {
            try
            {
                MainViewModel model = new MainViewModel();
                if (id != null)
                {
                   
                    //IEnumerable<Fiches> fiche;// = new IEnumerable<Fiche>();
                    //model.fiche = await _unitOfWork.Fiches.GetAllFichesByStudentId(id);
                    //model.activiteType = await _unitOfWork.ActiviteTypes.GetAllWithFicheByFicheIdAsync(id);
                    //model.concerne = await _unitOfWork.Concernes.GetAllWithFicheByFicheIdAsync(id);
                    //Running Code Below start
                    //model.fiche = await _unitOfWork.Fiches.GetAllByIdAsync(id);
                    //model.activite = await _unitOfWork.Activites.GetAllAsync();
                    //model.assurancePersonne = await _unitOfWork.AssurancesPersonne.GetAllAsync();
                    //model.assuranceDommage = await _unitOfWork.AssurancesDommage.GetAllAsync();
                    //End
                    model = await getDocumentData(id);
                }
                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message.ToString());
            }
        }

        private async Task<MainViewModel> getDocumentData(int id)
        {
            MainViewModel model = new MainViewModel();
            model.fiche = await _unitOfWork.Fiches.GetAllByIdAsync(id);
            model.activite = await _unitOfWork.Activites.GetAllAsync();
            model.activiteType = await _unitOfWork.ActiviteTypes.GetAllAsync();
            model.assurancePersonne = await _unitOfWork.AssurancesPersonne.GetAllAsync();
            model.assuranceDommage = await _unitOfWork.AssurancesDommage.GetAllAsync();
            model.ficheContexteSimplifiee = await _unitOfWork.FichesContexteSimplifiee.GetWithFichesByIdAsync(id);
            model.ficheClientProspect = await _unitOfWork.FichesClientProspect.GetWithFichesByIdAsync(id);
            model.descriptionActivite = await _unitOfWork.DescriptionsActivite.GetWithFichesByIdAsync(id);
            model.phase = await _unitOfWork.Phases.GetWithFichesByIdAsync(id);
            return model;
        }
        [HttpGet]
        [Route("CreatePDF/{id}")]
        public async Task<ActionResult> CreatePDF(int id)//public byte[] CreatePDF(int id)
        {
            try
            {
                MainViewModel model = new MainViewModel();
                model = await getDocumentData(id);
                var globalSettings = new GlobalSettings
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings { Top = 10 },
                    DocumentTitle = "PDF Report",
                    //Out = @"D:\PDFCreator\Employee_Report.pdf"
                };
                var objectSettings = new ObjectSettings
                {
                    PagesCount = true,
                    HtmlContent = TemplateGenerator.GetHTMLString(model),
                    WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "libwkhtmltox.dll", "assets", "styles.css") },
                    HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                    FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
                };
                var pdf = new HtmlToPdfDocument()
                {
                    GlobalSettings = globalSettings,
                    Objects = { objectSettings }
                };
                //return _converter.Convert(pdf);
                var file = _converter.Convert(pdf);
                //return File(file, "application/pdf");
                return File(file, "application/pdf", "EmployeeReport.pdf");//"application/pdf"
            }
            catch(Exception ex)
            {
                //byte[] emp = null;
                //return emp;
                return null;
            }
            // _converter = new IConverter();
            
            //return Ok("Successfully created PDF document.");
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
        public void Post([FromBody] MainViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.fiche.Id = _unitOfWork.Fiches.Add(model.fiche);
                model.ficheClientProspect.FicheId = model.fiche.Id;
                _unitOfWork.FichesClientProspect.Add(model.ficheClientProspect);
                model.phase.FicheId = model.fiche.Id;
                _unitOfWork.Phases.Add(model.phase);
                model.ficheContexteSimplifiee.FicheId = model.fiche.Id;
                _unitOfWork.FichesContexteSimplifiee.Add(model.ficheContexteSimplifiee);
                //model.contratsPortefeuille.FicheId = model.fiche.Id;
                //_unitOfWork.ContratsPortefeuilles.Add(model.contratsPortefeuille);
                model.descriptionActivite.FicheId = model.fiche.Id;
                _unitOfWork.DescriptionsActivite.Add(model.descriptionActivite);
                //model.phase.FicheId = model.fiche.Id;
                //_unitOfWork.Phases.Add(model.phase);
            }
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
