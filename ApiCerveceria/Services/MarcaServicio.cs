using ApiCerveceria.Data;
using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiCerveceria.Services
{
    public class MarcaServicio : IMarcaServicio
    {
        private readonly CerveceriaContext _cerveceriaContext;
        public MarcaServicio(CerveceriaContext cerveceriaContext)
        {
            this._cerveceriaContext = cerveceriaContext;
        }
        public async Task<IEnumerable<Marca>> GetMarcas()
        {
            return await this._cerveceriaContext.Marcas.ToListAsync ();
        }

        public async Task<Marca>GetMarcasById(int id)
        {
            return await this._cerveceriaContext.Marcas.FirstOrDefaultAsync(x => x.MarcaId.Equals(id));
        }
    }
}
