using AgendaEscolarApp.Application.Users.Commands;
using AgendaEscolarApp.Application.Users.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaEscolarApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsuariosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> CriarUsuario(CriarUsuarioCommand command)
        {
            var id = await _mediator.Send(command);
            return Ok(id);
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> GetUsuarios()
        {
            var usuarios = await _mediator.Send(new GetUsuariosQuery());
            return Ok(usuarios);
        }
    }
}
