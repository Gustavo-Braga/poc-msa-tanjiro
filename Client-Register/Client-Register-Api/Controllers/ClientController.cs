using ClientRegister.Driver.Port.ClientRequest;
using ClientRegister.Driver.Port.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading.Tasks;

namespace Client_Register_Api.Controllers
{
    [ApiController]
    [Route("api/v1/client")]
    public class ClientController : ControllerBase
    {
        public readonly IClientCommandHandler _clientCommandHandler;

        public ClientController(IClientCommandHandler clientCommandHandler)
        {
            _clientCommandHandler = clientCommandHandler;
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Retorna Id do usuário inserido",
            Description = "Endpoint utilizado para cadastrar um novo cliente",
            OperationId = "PostClient")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Guid))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] AddClientRequest request)
        {
            try
            {
                return Ok(new { id = await _clientCommandHandler.Create(request) });
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
