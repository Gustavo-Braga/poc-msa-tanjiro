using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Client_Register_Api.Controllers
{
    public class ApiBaseController : ControllerBase
    {
        public readonly IMediator _mediator;

        public ApiBaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<IActionResult> CreateResponse<T>(Func<Task<T>> function)
        {
            try
            {
                var data = await function();
                return Ok(new { data, success = true });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { data = default(Nullable), success = false, notifications = ex.Message });
            }
        }

    }
}
