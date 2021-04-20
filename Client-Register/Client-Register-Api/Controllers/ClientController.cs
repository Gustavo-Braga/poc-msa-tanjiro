using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Client_Register_Api.Controllers
{
    [ApiController]
    [Route("api/v1/client")]
    public class ClientController : ApiBaseController
    {
        public ClientController(IMediator mediator): base(mediator)
        {
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await CreateResponse(async () => await _mediator.Send(new List<string>()));
        }
    }
}
