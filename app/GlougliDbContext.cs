using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app {
    public class GlougliDbCOntext : DbContext {

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql ("Host=localhost;Database=banco;Username=postgres;Password=12345");

        public DbSet<Conteudo> Conteudo { get; set; }
        public DbSet<Pagina> Pagina { get; set; }
    }

}