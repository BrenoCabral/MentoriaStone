using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria
{
    //Blbioteca tem que conter uma pratileira
    //Pratileira tem que conter livros e revistas
    //Livros e revistas (publicacao) tem páginas
    //Páginas tem texto
    public class Biblioteca
    {
        private IItensEmprestados _listaDeItens;
        public Colecao Pratileiras { get; set; }
        public Biblioteca(IItensEmprestados itensEmprestados)
        {
            _listaDeItens = itensEmprestados;
        }

        public void Adicionar(Publicacao publicacao)
        {
            Pratileiras.AcrescentarItem(publicacao);
        }

        public Publicacao PegarPublicacao(string titulo)
        {
            Publicacao publicacao = Pratileiras.BuscarItem(titulo);

            _listaDeItens.AdicionaItem(publicacao);

            return publicacao;
        }
    }
}
