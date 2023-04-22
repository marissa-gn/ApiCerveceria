using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCerveceria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorServicio _vendedorServicio;
        public VendedorController(IVendedorServicio vendedorServicio)
        {
            this._vendedorServicio = vendedorServicio;
        }
        // GET: api/<VendedorController>
        [HttpGet]
        public async Task<IEnumerable<Vendedor>> Get()
        {
            return await this._vendedorServicio.GetVendedores(); 
        }

        // GET api/<VendedorController>/5
        [HttpGet("{id}")]
        public async Task <Vendedor> Get(int id)
        {
            return await this._vendedorServicio.GetVendedoresById(id);
        }

        // POST api/<VendedorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VendedorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VendedorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
