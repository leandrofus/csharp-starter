using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthSQLiteExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectedController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetSecretData()
        {
            return Ok("Este es un dato protegido.");
        }
    }
    public class testController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetSecretData()
        {
            return Ok("Este es un dato protegido.");
        }
    }
}