using CarrinhoDeCompra.Modelos;
using Microsoft.EntityFrameworkCore;

namespace CarrinhoDeCompra.DbContexts
{
    public class CarrinhoDbContext : DbContext
    {
        public CarrinhoDbContext(DbContextOptions<CarrinhoDbContext> options)
            : base(options)
        {
        }

        public DbSet<CarrinhoDeCompras> CarrinhoDeCompras { get; set; }

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
