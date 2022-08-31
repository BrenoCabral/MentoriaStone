namespace MentoriaNet
{
    public class MetodoDeExtracao
    {
        
        public string Nome { get; set; }
        public int GrossuraDoPo { get; set; }
        public string Filtro { get; set; }

        public string Tipo { get; set; }

        public virtual Cafe FazExtracao(Grao grao)
        {
            return new Cafe();
        }
        public void SelecionaFiltro()
        {
            // faz umas parada
        }

    }

    public class HarioV60 : MetodoDeExtracao
    {

        public bool SuporteDeCeramica { get; set; }
        public override Cafe FazExtracao(Grao grao)
        {
            Console.WriteLine("Café linpinho topzera");
            
            SelecionaFiltro();
            return new ();
        }
        private void SelecionaFiltroDaArio(Grao grao)
        {

        }
    }

    public class Chemex : MetodoDeExtracao
    {
        public override Cafe FazExtracao(Grao grao)
        {
            Console.WriteLine("Café ainda mais incrível");
            return new();
        }
    }
}