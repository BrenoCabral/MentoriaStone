
namespace Cliente.Client
{
    public interface IEventoClient
    {
        void CriarEvento(int id);
        Task<Evento> GetEvento(int id);
    }
}