using ApiCerveceria.Models;

namespace ApiCerveceria.Services.Interface
{
    public interface IMarcaServicio
    {
        Task<Marca> GetMarcasById(int id);
        Task<IEnumerable<Marca>> GetMarcas();
    }
}
