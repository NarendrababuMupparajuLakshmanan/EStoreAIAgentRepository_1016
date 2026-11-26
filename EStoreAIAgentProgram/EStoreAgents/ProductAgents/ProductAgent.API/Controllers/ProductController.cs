using MediatR;
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
        public async Task<IActionResult>
            ListProduct(CancellationToken cancellationToken)
        {
            var query = new ListAllProductQuery();

            var result = await this._mediator.Send(query, cancellationToken);

            return Ok(result);
        }

        [HttpGet]
        [Route("GetProductById/{Id:guid}")]
        public async Task<IActionResult>
            GetProductById(Guid Id, CancellationToken cancellationToken)
        {
            var query = new GetProductByIdQuery(Id);

            var result = await this._mediator.Send(query, cancellationToken);

            return Ok(result);
        }
    }
}
