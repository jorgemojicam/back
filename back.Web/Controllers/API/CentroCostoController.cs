
namespace back.Web.Controllers.API
{
    using back.Web.Data;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    [Route("api/[Controller]")]
    public class CentroCostoController : Controller
    {
        private readonly ICentroCostoRepository CentroCostoRepository;

        public CentroCostoController(ICentroCostoRepository CentroCostoRepository)
        {
            this.CentroCostoRepository = CentroCostoRepository;
        }

        [HttpGet]
        public IActionResult GetCentroCosto()
        {
            return Ok(this.CentroCostoRepository.GetAll().OrderBy(a => a.Nombre));
        }

        [Route("GetByMunicipio")]
        public IActionResult GetCentroCostoByMun(int id)
        {
            var CentroCosto = this.CentroCostoRepository.GetByMunicipio().Where(a => a.Municipio.Id == id);
            return Ok(CentroCosto);
        }

        [Route("GetByRegional")]
        public IActionResult GetCentroCostoByReg(int id)
        {
            var CentroCosto = this.CentroCostoRepository.GetByMunicipio().Where(a => a.Regional.Id == id);
            return Ok(CentroCosto);
        }

        [Route("GetOficinas")]
        public IActionResult GetOficinas()
        {
            var CentroCosto = this.CentroCostoRepository.GetByRegional().Where(a => a.Regional.Id != 0);
            return Ok(CentroCosto);
        }
    }
}