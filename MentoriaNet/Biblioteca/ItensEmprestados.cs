namespace Livraria
{
    public class ItensEmprestados : IItensEmprestados
    {
        public List<Publicacao> Publicacoes { get; set; }
        public void AdicionaItem(Publicacao publicacao)
        {
            Publicacoes.Add(publicacao);
        }
    }
}