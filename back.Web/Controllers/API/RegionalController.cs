

namespace back.Web.Controllers.API
{
    using Data;
    using Data.Entities;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class RegionalController : Controller
    {
        private readonly IRegionalRepository RegionalRepository;

        public RegionalController(IRegionalRepository RegionalRepository)
        {
            this.RegionalRepository = RegionalRepository;
        }

        // GET: api/Regional
        [HttpGet]
        public IActionResult GetRegional()
        {
            return Ok(this.RegionalRepository.GetAll());
        }

        // GET: api/Regional/5
        [HttpGet("{id}", Name = "GetRegional")]
        public async Task<IActionResult> GetRegional(int id)
        {
            var Regional = await this.RegionalRepository.GetByIdAsync(id);
            return Ok(Regional);
        }

        // POST: api/Regional
        [HttpPost]
        public async Task<IActionResult> CreateRegional([FromBody] Common.Models.RegionalCommon RegionalCommon)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
           
            var entityRegional = new Regional
            {
                Nombre = RegionalCommon.Nombre
            };
            var newRegional = await this.RegionalRepository.CreateAsync(entityRegional);
            return Ok(newRegional);

        }

        // PUT: api/Regional/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegional([FromRoute] int id, [FromBody] Common.Models.RegionalCommon RegionalCommon)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            if (id != RegionalCommon.Id)
            {
                return this.BadRequest();
            }
            var oldRegional = await this.RegionalRepository.GetByIdAsync(id);
            if (oldRegional == null)
            {
                return this.BadRequest("No se encontro el Regional");
            }

            oldRegional.Nombre = RegionalCommon.Nombre;

            var updateSol = await this.RegionalRepository.UpdateAsync(oldRegional);
            return Ok(updateSol);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void DeleteRegional(int id)
        {
        }
    }
}
