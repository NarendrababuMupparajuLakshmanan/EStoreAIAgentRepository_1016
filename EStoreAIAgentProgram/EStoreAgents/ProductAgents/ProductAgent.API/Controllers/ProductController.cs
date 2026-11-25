using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ProductAgent.Application.Queries;

namespace ProductAgent.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        [Route("ListProduct")]
        public IActionResult ListProduct()
        {
            var query = new ListAllProductQuery();

            var result = this._mediator.Send(query).Result;

            return Ok(result);
        }
    }
}
