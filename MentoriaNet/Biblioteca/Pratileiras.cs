namespace Livraria
{
    public class Colecao
    {
        public List<Pratileira> Pratileiras { get; set; }

        internal void AcrescentarItem(Publicacao publicacao)
        {
            foreach (var pratileira in Pratileiras)
            {
                if (pratileira.TemEspaco())
                {
                    pratileira.AcrescentarItem(publicacao);
                    return;
                }
            }
        }

        internal Publicacao BuscarItem(string titulo)
        {
            var publicacao = new Publicacao();
            publicacao = Pratileiras.Select(pratileira => pratileira.BuscarItem(titulo)).FirstOrDefault();
            return publicacao;
        }
    }
}