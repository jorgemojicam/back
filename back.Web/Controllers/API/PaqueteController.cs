

namespace back.Web.Controllers.API
{
    using Data;
    using Data.Entities;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class PaqueteController : Controller
    {
        private readonly IPaqueteRepository paqueteRepository;

        public PaqueteController(IPaqueteRepository PaqueteRepository)
        {
            this.paqueteRepository = PaqueteRepository;
        }

        // GET: api/Paquete
        [HttpGet]
        public IActionResult GetPaquete()
        {
            return Ok(this.paqueteRepository.GetAll());
        }

        // GET: api/Paquete/5
        [HttpGet("{id}", Name = "GetPaquete")]
        public async Task<IActionResult> GetPaquete(int id)
        {
            var Paquete = await this.paqueteRepository.GetByIdAsync(id);
            return Ok(Paquete);
        }

        // POST: api/Paquete
        [HttpPost]
        public async Task<IActionResult> CreatePaquete([FromBody] Common.Models.PaqueteCommon PaqueteCommon)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
           
            var entityPaquete = new Paquete
            {
                Anexo = PaqueteCommon.Anexo,
                Asunto = PaqueteCommon.Asunto,
                Cantidad = PaqueteCommon.Cantidad,
                CedulaDestinatario = PaqueteCommon.CedulaDestinatario,
                ContenidoId = PaqueteCommon.Contenido.Id,
                DireccionDestino = PaqueteCommon.DireccionDestino,
                MunicipioId = PaqueteCommon.Municipio.Id,
                NombreDestinatario = PaqueteCommon.NombreDestinatario,
                OficinaDestino = PaqueteCommon.OficinaDestino,
            };
            var newPaquete = await this.paqueteRepository.CreateAsync(entityPaquete);
            return Ok(newPaquete);

        }

        // PUT: api/Paquete/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaquete([FromRoute] int id, [FromBody] Common.Models.PaqueteCommon PaqueteCommon)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            if (id != PaqueteCommon.Id)
            {
                return this.BadRequest();
            }
            var oldPaquete = await this.paqueteRepository.GetByIdAsync(id);
            if (oldPaquete == null)
            {
                return this.BadRequest("No se encontro el Paquete");
            }

            oldPaquete.Anexo = PaqueteCommon.Anexo;
            oldPaquete.Asunto = PaqueteCommon.Asunto;
            oldPaquete.Cantidad = PaqueteCommon.Cantidad;
            oldPaquete.CedulaDestinatario = PaqueteCommon.CedulaDestinatario;
            oldPaquete.ContenidoId = PaqueteCommon.Contenido.Id;
            oldPaquete.DireccionDestino = PaqueteCommon.DireccionDestino;
            oldPaquete.MunicipioId = PaqueteCommon.Municipio.Id;
            oldPaquete.NombreDestinatario = PaqueteCommon.NombreDestinatario;
            oldPaquete.OficinaDestino = PaqueteCommon.OficinaDestino;

            var updateSol = await this.paqueteRepository.UpdateAsync(oldPaquete);
            return Ok(updateSol);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeletePaquete(int id)
        {
        }
    }
}
