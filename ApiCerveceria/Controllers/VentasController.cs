using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCerveceria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly IVentaServicio _ventaServicio;
        public VentasController(IVentaServicio ventaServicio)
        {
            this._ventaServicio = ventaServicio;
        }

        // GET: api/<VentasController>
        [HttpGet]
        public async Task<IEnumerable<Ventas>>Get()
        {
            return await this._ventaServicio.GetVentas();
        }

        // GET api/<VentasController>/5
        [HttpGet("{id}")]
        public async Task<Ventas>Get(int id)
        {
            return await this._ventaServicio.GetVentasById(id);
        }

        // POST api/<VentasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VentasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VentasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
