using CarrinhoDeCompra.DbContexts;
using CarrinhoDeCompra.Modelos;

namespace CarrinhoDeCompra.Services
{
    public class CarrinhoDeCompraService : ICarrinhoDeCompraService
    {
        private CarrinhoDbContext _dbContext { get; set; }
        public CarrinhoDeCompraService(CarrinhoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<CarrinhoDeCompras> BuscarCarrinho(int id)
        {
            var carrinho = _dbContext.CarrinhoDeCompras.Where(c=>c.Equals(id)).FirstOrDefault();
            if (carrinho == null)
                carrinho = await SalvarCarrinho(id);

            return carrinho;
        }

        public async Task<CarrinhoDeCompras> SalvarCarrinho(int id)
        {
            var carrinho = new CarrinhoDeCompras();
            carrinho.Id = id;
            
            _dbContext.CarrinhoDeCompras.Add(carrinho);
            await _dbContext.SaveChangesAsync();
            return carrinho;
        }

        public void AdicionarItem(int idCarrinho, int idItem)
        {

        }

        public void RemoveItem(int idCarrinho, int idItem)
        {

        }
    }
}
