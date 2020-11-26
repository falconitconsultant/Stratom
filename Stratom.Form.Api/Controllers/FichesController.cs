using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stratom.Form.Core;
using Stratom.Form.Core.Models;
using Stratom.Form.Data;

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
        public async Task<ActionResult> GetDocuments()
        {
            try
            {
                return Ok(await _unitOfWork.Fiches.GetAllFichesAsync());
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
