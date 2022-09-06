using CarrinhoDeCompra.Modelos;

namespace CarrinhoDeCompra.Services
{
    public class CarrinhoDeCompraService : ICarrinhoDeCompraService
    {
        public CarrinhoDeCompras BuscarCarrinho(int id)
        {
            return new();
        }

        public void SalvarCarrinho(int id)
        {

        }

        public void AdicionarItem(int idCarrinho, int idItem)
        {

        }

        public void RemoveItem(int idCarrinho, int idItem)
        {

        }
    }
}
