using CarrinhoDeCompra.Modelos;
using CarrinhoDeCompra.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarrinhoDeCompra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoDeComprasController : ControllerBase
    {
        private ICarrinhoDeCompraService _carrinhoDeCompraService { get; set; }
        public CarrinhoDeComprasController(ICarrinhoDeCompraService carrinhoDeCompraService)
        {
            _carrinhoDeCompraService = carrinhoDeCompraService;
        }
        // GET: api/<CarrinhoDeComprasController>
        [HttpGet("{id}")]
        public CarrinhoDeCompras BuscarCarrinho(int id)
        {
            var carrinho = _carrinhoDeCompraService.BuscarCarrinho(id);
            return carrinho;
        }

        // POST api/<CarrinhoDeComprasController>
        [HttpPost]
        public void Post([FromBody] int id)
        {
            _carrinhoDeCompraService.SalvarCarrinho(id);
        }

        // POST api/CarrinhoDeCompras/1
        [HttpPost("{idCarrinho}")]
        public void AdicionaItem(int idCarrinho,[FromBody] int idEvento)
        {
            _carrinhoDeCompraService.AdicionarItem(idCarrinho, idEvento);
            //buscarCarrinho
        }

    }
}
