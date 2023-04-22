using ApiCerveceria.Models;

namespace ApiCerveceria.Services.Interface
{
    public interface ITipoServicio
    {
        Task<Tipo> GetTiposById(int id);
        Task<IEnumerable<Tipo>> GetTipos();
    }
}
