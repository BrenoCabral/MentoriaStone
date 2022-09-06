﻿using CarrinhoDeCompra.Modelos;

namespace CarrinhoDeCompra.Services
{
    public interface ICarrinhoDeCompraService
    {
        void AdicionarItem(int idCarrinho, int idItem);
        CarrinhoDeCompras BuscarCarrinho(int id);
        void RemoveItem(int idCarrinho, int idItem);
        void SalvarCarrinho(int id);
    }
}