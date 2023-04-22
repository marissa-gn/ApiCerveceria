using ApiCerveceria.Data;
using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiCerveceria.Services
{
    public class VentaServicio : IVentaServicio
    {
        private readonly CerveceriaContext _cerveceriaContext;
        public VentaServicio(CerveceriaContext cerveceriaContext)
        {
            this._cerveceriaContext = cerveceriaContext;
        }
        public async Task<IEnumerable<Ventas>> GetVentas()
        {
            return await this._cerveceriaContext.Ventas.ToListAsync();
        }

        public async Task<Ventas> GetVentasById(int id)
        {
            return await this._cerveceriaContext.Ventas.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
