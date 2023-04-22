using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCerveceria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoController : ControllerBase
    {
        private readonly ITipoServicio _tipoServicio;
        public TipoController(ITipoServicio tipoServicio)
        {
            this._tipoServicio = tipoServicio;
        }
        // GET: api/<TipoController>
        [HttpGet]
        public async Task <IEnumerable<Tipo>> Get()
        {
            return await this._tipoServicio.GetTipos();
        }

        // GET api/<TipoController>/5
        [HttpGet("{id}")]
        public async Task <Tipo> Get(int id)
        {
            return await this._tipoServicio.GetTiposById(id);
        }

        // POST api/<TipoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TipoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
