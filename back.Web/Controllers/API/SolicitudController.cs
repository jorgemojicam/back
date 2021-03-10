

namespace back.Web.Controllers.API
{
    using Data;
    using Data.Entities;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class SolicitudController : Controller
    {
        private readonly ISolicitudRepository solicitudRepository;

        public SolicitudController(ISolicitudRepository solicitudRepository)
        {
            this.solicitudRepository = solicitudRepository;
        }

        // GET: api/Solicitud
        [HttpGet]
        public IActionResult GetSolicitud()
        {
            return Ok(this.solicitudRepository.GetAll());
        }

        // GET: api/Solicitud/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            var solicitud = await this.solicitudRepository.GetByIdAsync(id);
            return Ok(solicitud);
        }

        // POST: api/Solicitud
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Common.Models.Solicitud solicitud)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            var entitySolicitud = new Solicitud
            {
                Modo = solicitud.Modo,
                CentroCosto = solicitud.CentroCosto,
                Estado = solicitud.Estado,
                EstadoCentroCosto = solicitud.EstadoCentroCosto,
                FechaCreacion = solicitud.FechaCreacion,
                FechaEnvio = solicitud.FechaEnvio,
                Guia = solicitud.Guia,
                Origen = solicitud.Origen,
                Precinto = solicitud.Precinto,
                Solicitante = solicitud.Solicitante,
                Tipo = solicitud.Tipo,
                UnidadEmpaque = solicitud.UnidadEmpaque
            };
            var newSolicitud = await this.solicitudRepository.CreateAsync(entitySolicitud);
            return Ok(newSolicitud);

        }

        // PUT: api/Solicitud/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] int id, [FromBody] Common.Models.Solicitud solicitud)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            if (id != solicitud.Id)
            {
                return this.BadRequest();
            }
            var oldSolicitud = await this.solicitudRepository.GetByIdAsync(id);
            if (oldSolicitud == null)
            {
                return this.BadRequest("No se encontro la solicitud");
            }

            oldSolicitud.Modo = solicitud.Modo;
            oldSolicitud.CentroCosto = solicitud.CentroCosto;
            oldSolicitud.Estado = solicitud.Estado;
            oldSolicitud.EstadoCentroCosto = solicitud.EstadoCentroCosto;
            oldSolicitud.FechaCreacion = solicitud.FechaCreacion;
            oldSolicitud.FechaEnvio = solicitud.FechaEnvio;
            oldSolicitud.Guia = solicitud.Guia;
            oldSolicitud.Origen = solicitud.Origen;
            oldSolicitud.Precinto = solicitud.Precinto;
            oldSolicitud.Solicitante = solicitud.Solicitante;
            oldSolicitud.Tipo = solicitud.Tipo;
            oldSolicitud.UnidadEmpaque = solicitud.UnidadEmpaque;

            var updateSol = await this.solicitudRepository.UpdateAsync(oldSolicitud);
            return Ok(updateSol);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
