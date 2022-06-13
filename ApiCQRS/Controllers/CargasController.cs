using ApiCQRS.Context;
using ApiCQRS.Model;
using ApiCQRS.Resources.Commands;
using ApiCQRS.Resources.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CargasController(IMediator mediator)        
           => _mediator = mediator;        

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Carga>>> GetProdutos()
        {
            try
            {
                var command = new GetCargasQuery();
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Carga>> GetProdutos(int id)
        {
            try
            {
                var command = new GetCargasByIdQuery { Id = id };
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Carga>> PostProduto([FromBody] CargaCreateCommand command)
        {
            try
            {
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Carga>> DeleteProduto(int id)
        {
            try
            {
                var command = new CargaDeleteCommand { Id = id };
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<ActionResult<Carga>> PutProduto([FromBody] CargaUpdateCommand command)
        {
            try
            {
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}