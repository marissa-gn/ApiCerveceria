using ApiCerveceria.Data;
using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiCerveceria.Services
{
    public class TipoServicio : ITipoServicio
    {
        private readonly CerveceriaContext _cerveceriaContext;
        public TipoServicio(CerveceriaContext cerveceriaContext)
        {
            this._cerveceriaContext = cerveceriaContext;
        }
        public async Task<IEnumerable<Tipo>> GetTipos()
        {
            return await this._cerveceriaContext.Tipos.ToListAsync();
        }

        public async Task<Tipo> GetTiposById(int id)
        {
            return await this._cerveceriaContext.Tipos.FirstOrDefaultAsync(x => x.TipoId.Equals(id));
        }
    }
}
