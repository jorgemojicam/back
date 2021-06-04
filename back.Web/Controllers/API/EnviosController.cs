

namespace back.Web.Controllers.API
{
    using Data;
    using Data.Entities;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class EnviosController : Controller
    {
        private readonly IEnviosRepository EnviosRepository;

        public EnviosController(IEnviosRepository EnviosRepository)
        {
            this.EnviosRepository = EnviosRepository;
        }

        // GET: api/Envios
        [HttpGet]
        public IActionResult GetEnvios()
        {
            return Ok(this.EnviosRepository.GetAll());
        }
        
        // GET: api/Envios/5
        [HttpGet("{id}", Name = "GetEnvios")]
        public async Task<IActionResult> GetEnvios(int id)
        {
            var Envios = await this.EnviosRepository.GetByIdAsync(id);
            return Ok(Envios);
        }
        
        // POST: api/Envios
        [HttpPost]
        public async Task<IActionResult> CreateEnvios([FromBody] Common.Models.EnviosCommon Envios)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            var entityEnvios = new Envios
            {
                CentroCostoId = Envios.CentroCostoId,
                FechaEnvios = Envios.FechaEnvios
            };
            var newEnvios = await this.EnviosRepository.CreateAsync(entityEnvios);
            return Ok(newEnvios);

        }

        // PUT: api/Envios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEnvios([FromRoute] int id, [FromBody] Common.Models.EnviosCommon Envios)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            if (id != Envios.Id)
            {
                return this.BadRequest();
            }
            var oldEnvios = await this.EnviosRepository.GetByIdAsync(id);
            if (oldEnvios == null)
            {
                return this.BadRequest("No se encontro la Envios");
            }
            oldEnvios.CentroCostoId = Envios.CentroCostoId;           
            oldEnvios.FechaEnvios = Envios.FechaEnvios;
            var updateSol = await this.EnviosRepository.UpdateAsync(oldEnvios);
            return Ok(updateSol);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteEnvios(int id)
        {

        }

        [Route("GetByCentroCosto")]
        public IActionResult GetByCentroCosto(int id)
        {
            var Envios = this.EnviosRepository.GetByCentroCosto().Where(a => a.CentroCostoId == id).ToList();
            return Ok(Envios);
        }
   
        [Route("GetByFecha")]
        public IActionResult GetByFecha(int centrocosto, DateTime fecha)
        {
            var envios = this.EnviosRepository.GetByCentroCosto().Where(a => a.CentroCostoId == centrocosto && a.FechaEnvios > fecha).OrderByDescending(t => t.FechaEnvios).First();
            return Ok(envios);
        }
      
    }
}
