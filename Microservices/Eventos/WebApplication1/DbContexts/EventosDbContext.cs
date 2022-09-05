using Microsoft.EntityFrameworkCore;
using WebApplication1.Entidades;

namespace WebApplication1.DbContexts
{
    public class EventosDbContext:DbContext
    {
        public EventosDbContext(DbContextOptions<EventosDbContext> options)
            : base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }

    
}
