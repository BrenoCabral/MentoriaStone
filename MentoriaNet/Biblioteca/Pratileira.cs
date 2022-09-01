namespace Livraria
{
    public class Pratileira
    {
        private const int CAPACIDADE = 10;
        public List<Publicacao> Publicacoes { get; set; }

        internal void AcrescentarItem(Publicacao publicacao)
        {
            if (Publicacoes.Count == 10) return;

            Publicacoes.Add(publicacao);
        }

        internal bool TemEspaco()
        {
            return Publicacoes.Count < CAPACIDADE;
        }

        internal Publicacao BuscarItem(string titulo)
        {
            return Publicacoes.Where(publicacao => publicacao.Titulo == titulo).FirstOrDefault();
        }
    }
}