using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DbContexts;
using WebApplication1.Entidades;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        public EventosDbContext _dbContext { get; set; }
        public EventosController(EventosDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        // GET: api/<EventosController>
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _dbContext.Eventos.ToList();
        }

        // GET api/<EventosController>/5
        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return _dbContext.Eventos.Where(evento => evento.Id == id)?.FirstOrDefault();
        }

        // POST api/<EventosController>
        [HttpPost]
        public void Post([FromBody] int value)
        {
            var evento = new Evento() { Id = value };
            _dbContext.Eventos.Add(evento);
            _dbContext.SaveChangesAsync();
        }

        // PUT api/<EventosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EventosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
