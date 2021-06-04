

namespace back.Web.Controllers.API
{
    using back.Common.Models;
    using Data;
    using Data.Entities;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
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
        public async Task<IActionResult> CreateSolicitudPaquete([FromBody] IList<SolicitudPaqueteCommon> solicitud)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            List<SolicitudPaquete> newListPaquete = new List<SolicitudPaquete>();
            foreach (SolicitudPaqueteCommon paqueteCommon in solicitud)
            {

                var entityPaquete = new SolicitudPaquete
                {
                    SolicitudId = paqueteCommon.SolicitudId,
                    PaqueteId = paqueteCommon.PaqueteId

                };
                var newPaquete = await this.solicitudpaqueteRepository.CreateAsync(entityPaquete);
                newListPaquete.Add(newPaquete);
            }
            return Ok(newListPaquete);
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
