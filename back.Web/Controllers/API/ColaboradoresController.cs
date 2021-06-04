
namespace back.Web.Controllers.API
{
    using back.Web.Data;
    using back.Web.Data.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/[Controller]")]
    public class ColaboradoresController : Controller
    {
        private readonly IColaboradoresRepository ColaboradoresRepository;

        public ColaboradoresController(IColaboradoresRepository ColaboradoresRepository)
        {
            this.ColaboradoresRepository = ColaboradoresRepository;
        }  

        [HttpGet]
        public IActionResult GetColaboradores()
        {
            return Ok(this.ColaboradoresRepository.GetAll().Include(a => a.CentroCosto).Include(r => r.Rol));
        }

        [Route("GetByUser")]
        public IActionResult GetColaboradoresByUser(string user)
        {
            var Colaboradores = this.ColaboradoresRepository.GetByCentroCosto().Where(a => a.Username == user);
            return Ok(Colaboradores);
        }
        // POST: api/Colaboradores
        [HttpPost]
        public async Task<IActionResult> CreateColaboradores([FromBody] Common.Models.ColaboradoresCommon colaborador)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            var entityCol = new Colaboradores
            {
                Celular = colaborador.Celular,
                CentroCostoId = colaborador.CentroCostoId,
                Nombre = colaborador.Nombre,
                RolId= colaborador.RolId,
                Username = colaborador.Username
            };
            var newEnvios = await this.ColaboradoresRepository.CreateAsync(entityCol);
            return Ok(newEnvios);
        }

        // PUT: api/Colaboradores
        [HttpPut]
        public async Task<IActionResult> PutEnvios([FromBody] Common.Models.ColaboradoresCommon colaborador)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }
            if (colaborador.Id <= 0)
            {
                return this.BadRequest();
            }
            var oldColaborador = await this.ColaboradoresRepository.GetByIdAsync(colaborador.Id);
            if (oldColaborador == null)
            {
                return this.BadRequest("No se encontro el colaborador");
            }
            oldColaborador.CentroCostoId = colaborador.CentroCostoId;
            oldColaborador.Nombre = colaborador.Nombre;
            oldColaborador.RolId = colaborador.RolId;
            oldColaborador.Username = colaborador.Username;
            oldColaborador.Celular = colaborador.Celular;
            var updateSol = await this.ColaboradoresRepository.UpdateAsync(oldColaborador);
            return Ok(updateSol);
        }

    }
}