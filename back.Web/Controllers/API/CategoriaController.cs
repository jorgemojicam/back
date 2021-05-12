
namespace back.Web.Controllers.API
{
    using back.Web.Data;
    using Microsoft.AspNetCore.Mvc;


    [Route("api/[Controller]")]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository CategoriaRepository;

        public CategoriaController(ICategoriaRepository CategoriaRepository)
        {
            this.CategoriaRepository = CategoriaRepository;
        }
        [HttpGet]
        public IActionResult GetCategorias()
        {
            return Ok(this.CategoriaRepository.GetAll());
        }
    }
}