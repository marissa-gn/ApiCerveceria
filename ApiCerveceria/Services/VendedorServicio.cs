using ApiCerveceria.Data;
using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiCerveceria.Services
{
    public class VendedorServicio : IVendedorServicio
    {
        private readonly CerveceriaContext _cerveceriaContext;
        public VendedorServicio(CerveceriaContext cerveceriaContext)
        {
            this._cerveceriaContext = cerveceriaContext;
        }
        public async Task<IEnumerable<Vendedor>> GetVendedores()
        {
            return await this._cerveceriaContext.Vendedores.ToListAsync();
        }

        public async Task<Vendedor> GetVendedoresById(int id)
        {
            return await this._cerveceriaContext.Vendedores.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
