using ApiCerveceria.Models;

namespace ApiCerveceria.Services.Interface
{
    public interface IVentaServicio
    {
        Task<Ventas> GetVentasById(int id);
        Task<IEnumerable<Ventas>> GetVentas();
    }
}
