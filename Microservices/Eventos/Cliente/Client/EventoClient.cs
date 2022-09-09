using Newtonsoft.Json;

namespace Cliente.Client
{
    public class EventoClient : IEventoClient
    {
        private HttpClient _httpClient;
        private IHttpClientFactory _httpClientFactory;
        public EventoClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpClient = _httpClientFactory.CreateClient("evento");
        }

        public async Task<Evento> GetEvento(int id)
        {
            var evento = await _httpClient.GetFromJsonAsync<Evento>($"api/eventos/{id}");

            return evento;
        }

        public void CriarEvento(int id)
        {
            var json = JsonConvert.SerializeObject(id);
            var stringContent = new StringContent(json);

            _httpClient.PostAsync("api/eventos", stringContent);
        }
    }
}
