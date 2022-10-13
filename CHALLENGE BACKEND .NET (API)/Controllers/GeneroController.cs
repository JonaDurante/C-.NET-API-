using DB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CHALLENGE_BACKEND_.NET__API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private DataContext _context;

        public GeneroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Genero> GetAllGeneros() => _context.Generos.ToList();
    }
}
