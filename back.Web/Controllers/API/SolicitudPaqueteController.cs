

namespace back.Web.Controllers.API
{
    using Data;
    using Data.Entities;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class SolicitudPaqueteController : Controller
    {
        private readonly ISolicitudPaqueteRepository solicitudpaqueteRepository;

        public SolicitudPaqueteController(ISolicitudPaqueteRepository solicitudPaqueteRepository)
        {
            this.solicitudpaqueteRepository = solicitudPaqueteRepository;
        }

        // GET: api/Solicitud
        [HttpGet]
        public IActionResult GetSolicitudPaquete()
        {

            return Ok(this.solicitudpaqueteRepository.GetAll());
        }

        // GET: api/Solicitud/5
        [HttpGet("{id}", Name = "GetSolicitudPaquete")]
        public IActionResult GetSolicitudPaquete(int id)
        {
            var solicictud = this.solicitudpaqueteRepository.GetByPaquete().Where(a => a.Solicitud.Id == id);
            return Ok(solicictud);
        }

        // POST: api/Solicitud
        [HttpPost]
        public async Task<IActionResult> CreateSolicitudPaquete([FromBody] Common.Models.SolicitudPaqueteCommon solicitud)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            var entitySolicitud = new SolicitudPaquete
            {
                Solicitud = new Solicitud() { Id = solicitud.SolicitudId},
                Paquete = new Paquete() { Id = solicitud.PaqueteId },
            };
            var newSolicitud = await this.solicitudpaqueteRepository.CreateAsync(entitySolicitud);
            return Ok(newSolicitud);

        }

        // PUT: api/Solicitud/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSolicitudPaquete([FromRoute] int id, [FromBody] Common.Models.SolicitudPaqueteCommon solicitud)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            if (id != solicitud.Id)
            {
                return this.BadRequest();
            }
            var oldSolicitud = await this.solicitudpaqueteRepository.GetByIdAsync(id);
            if (oldSolicitud == null)
            {
                return this.BadRequest("No se encontro la solicitud");
            }

            oldSolicitud.Solicitud.Id = solicitud.SolicitudId;
            oldSolicitud.Paquete.Id = solicitud.PaqueteId;


            var updateSol = await this.solicitudpaqueteRepository.UpdateAsync(oldSolicitud);
            return Ok(updateSol);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteSolicitudPaquete(int id)
        {
        }
    }
}
