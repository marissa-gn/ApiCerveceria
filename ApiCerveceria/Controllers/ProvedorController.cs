using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCerveceria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvedorController : ControllerBase
    {
        private readonly IProvedorServicio _provedorServicio;
        public ProvedorController(IProvedorServicio provedorServicio)
        {
            this._provedorServicio = provedorServicio;
        }
        // GET: api/<ProvedorController>
        [HttpGet]
        public async Task<IEnumerable<Provedor>> Get()
        {
            return await this._provedorServicio.GetProvedores();
        }

        // GET api/<ProvedorController>/5
        [HttpGet("{id}")]
        public async Task <Provedor> Get(int id)
        {
            return await this._provedorServicio.GetProvedoresById(id);
        }

        // POST api/<ProvedorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProvedorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProvedorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
