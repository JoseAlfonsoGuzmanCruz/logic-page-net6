using logic_page_net6.Modelos;
using Microsoft.EntityFrameworkCore;

namespace logic_page_net6.Datos
{
    public class context : DbContext
    {
        public context(DbContextOptions<context> options) : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
    }
}
