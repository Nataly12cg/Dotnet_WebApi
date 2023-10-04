using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TODO.WebApli.Modelos;

namespace TODO.WebApli.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }

        // Aquí puedes definir relaciones entre entidades si es necesario.
    }
}


