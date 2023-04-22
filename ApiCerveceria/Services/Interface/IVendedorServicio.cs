using ApiCerveceria.Models;

namespace ApiCerveceria.Services.Interface
{
    public interface IVendedorServicio
    {
        Task<Vendedor> GetVendedoresById(int id);
        Task<IEnumerable<Vendedor>> GetVendedores();
    }
}
