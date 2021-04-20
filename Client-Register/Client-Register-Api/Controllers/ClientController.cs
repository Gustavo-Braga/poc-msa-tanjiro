using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Client_Register_Api.Controllers
{
    [ApiController]
    [Route("api/v1/client")]
    public class ClientController : ControllerBase
    {
        public ClientController()
        {
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return null;
        }
    }
}
