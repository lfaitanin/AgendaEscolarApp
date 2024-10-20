using AgendaEscolarApp.Application.Users.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AgendaEscolarApp.Application.Users.Handlers
{
    public class GetUsuariosHandler : IRequestHandler<GetUsuariosQuery, List<Usuario>>
    {
        private readonly ApplicationDbContext _context;

        public GetUsuariosHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Usuario>> Handle(GetUsuariosQuery request, CancellationToken cancellationToken)
        {
            return await _context.Usuarios.ToListAsync(cancellationToken);
        }
    }
}
