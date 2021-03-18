
namespace back.Web.Controllers.API
{
    using back.Web.Data;
    using Microsoft.AspNetCore.Mvc;


    [Route("api/[Controller]")]
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoRepository DepartamentoRepository;

        public DepartamentoController(IDepartamentoRepository DepartamentoRepository)
        {
            this.DepartamentoRepository = DepartamentoRepository;
        }
        [HttpGet]
        public IActionResult GetDepartamentos()
        {
            return Ok(this.DepartamentoRepository.GetAll());
        }
    }
}