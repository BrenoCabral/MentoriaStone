namespace Livraria
{
    public class Publicacao
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public List<Pagina> Paginas {get; set;}
    }
}