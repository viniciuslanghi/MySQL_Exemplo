using MySQL.Entidades;

namespace MySQL
{
    public class Contexto
    {
        public Contexto(DbContextoption<Contexto> option) : base(option) { }

        public DbSet<Usuario> USUARIOS { get; set; }
    }
}
