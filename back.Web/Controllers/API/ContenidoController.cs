
namespace back.Web.Controllers.API
{
    using back.Web.Data;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    [Route("api/[Controller]")]
    public class ContenidoController : Controller
    {
        private readonly IContenidoRepository ContenidoRepository;

        public ContenidoController(IContenidoRepository ContenidoRepository)
        {
            this.ContenidoRepository = ContenidoRepository;
        }
        [HttpGet]
        public IActionResult GetContenidos()
        {
            return Ok(this.ContenidoRepository.GetAll());
        }

        [Route("GetByCategoria")]
        public IActionResult GetContenidoByCategoria(int id)
        {
            var contenido = this.ContenidoRepository.GetByCategoria().Where(a => a.Categoria.Id == id);
            return Ok(contenido);
        }
    }
}