using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    //public DbSet<Aluno> Alunos { get; set; }
    //public DbSet<Evento> Eventos { get; set; }
    //// Outras tabelas...
}

public class Usuario
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public TipoUsuario TipoUsuario { get; set; }
}
public enum TipoUsuario
{
    Gestor,
    Professor,
    Responsavel
}