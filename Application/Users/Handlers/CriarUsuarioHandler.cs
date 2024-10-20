using AgendaEscolarApp.Application.Users.Commands;
using MediatR;

namespace AgendaEscolarApp.Application.Users.Handlers
{
    public class CriarUsuarioHandler : IRequestHandler<CriarUsuarioCommand, Guid>
    {
        private readonly ApplicationDbContext _context;

        public CriarUsuarioHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CriarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = new Usuario
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                Email = request.Email,
                Senha = request.Senha,
                TipoUsuario = request.TipoUsuario
            };

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync(cancellationToken);

            return usuario.Id;
        }
    }
}
