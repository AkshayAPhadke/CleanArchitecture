using CleanArchitectureDemo.Application.Beach.CreateBeach;
using CleanArchitectureDemo.Application.Beach.GetAllBeach;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BeachController : Controller
    {
        private readonly IMediator _mediator;
        public BeachController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var response = await _mediator.Send(new GetAllBeachesRequest());
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> PostAsync(CreateBeachRequest payload)
        {
            var newlyCreateItemId = await _mediator.Send(payload);
            return Ok(newlyCreateItemId);
        }

    }
}
