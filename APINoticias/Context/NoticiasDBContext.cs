using APINoticias.Models;
using Microsoft.EntityFrameworkCore;

namespace APINoticias.Context
{
    public class NoticiasDBContext : DbContext
    {

        public NoticiasDBContext(DbContextOptions<NoticiasDBContext> options) : base(options)
        {

        }

        public DbSet<NoticiaModel> Noticia { get; set; }

    }
}
