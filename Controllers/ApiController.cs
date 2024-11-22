using Microsoft.AspNetCore.Mvc;

namespace test3.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        public IActionResult Index()
        {
            return Ok(new {Bienvenido = ""});
        }
    }
}
