using ApiCerveceria.Models;

namespace ApiCerveceria.Services.Interface
{
    public interface IProvedorServicio
    {
        Task<Provedor> GetProvedoresById(int id);
        Task<IEnumerable<Provedor>> GetProvedores();
    }
}
