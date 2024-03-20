using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Traning_Platfrom_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthanticationController : ControllerBase
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetConfiguration()
        {
            return Ok();
        }
    }
}
