

namespace back.Web.Controllers.API
{
    using back.Web.Data;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    [Route("api/[Controller]")]
    public class MunicipioController : Controller
    {
        private readonly IMunicipioRepository MunicipioRepository;

        public MunicipioController(IMunicipioRepository MunicipioRepository)
        {
            this.MunicipioRepository = MunicipioRepository;
        }
        [HttpGet]
        public IActionResult GetMunicipios()
        {
            return Ok(this.MunicipioRepository.GetAll());
        }
        
      
        [Route("GetByDepartamento")]
        public IActionResult GetMunicipiosByDepartamento(int id)
        {
            var municipios = this.MunicipioRepository.GetByDepartamento().Where(a => a.Departamento.Id == id);
            return Ok(municipios);
        }
    }
}