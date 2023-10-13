using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PUCMinas_Projeto_Biblioteca.Models {
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Livros> Livros { get; set; }


    }
}
