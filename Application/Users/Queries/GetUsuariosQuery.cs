using MediatR;

namespace AgendaEscolarApp.Application.Users.Queries
{
    public class GetUsuariosQuery : IRequest<List<Usuario>>
    {
    }
}
