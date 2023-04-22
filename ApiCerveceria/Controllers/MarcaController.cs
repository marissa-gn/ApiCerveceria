using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCerveceria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaServicio _marcaServicio;
        public MarcaController(IMarcaServicio marcaServicio)
        {
            this._marcaServicio = marcaServicio;
        }

        // GET: api/<MarcaController>
        [HttpGet]
        public async Task<IEnumerable<Marca>> Get()
        {
            return await this._marcaServicio.GetMarcas();
        }

        // GET api/<MarcaController>/5
        [HttpGet("{id}")]
        public async Task<Marca>Get(int id)
        {
            return await this._marcaServicio.GetMarcasById(id);
        }

        // POST api/<MarcaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MarcaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MarcaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
