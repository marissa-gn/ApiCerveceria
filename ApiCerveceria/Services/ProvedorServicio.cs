using ApiCerveceria.Data;
using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiCerveceria.Services
{
    public class ProvedorServicio : IProvedorServicio
    {
        private readonly CerveceriaContext _cerveceriaContext;
        public ProvedorServicio(CerveceriaContext cerveceriaContext)
        {
            this._cerveceriaContext = cerveceriaContext;
        }
        public async Task<IEnumerable<Provedor>> GetProvedores()
        {
            return await this._cerveceriaContext.Provedores.ToListAsync();
        }

        public async Task<Provedor> GetProvedoresById(int id)
        {
            return await this._cerveceriaContext.Provedores.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
