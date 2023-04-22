using ApiCerveceria.Models;

namespace ApiCerveceria.Services.Interface
{
    public interface IProductoServicio
    {
        Task<Producto> GetProductosById(int id);
        Task<IEnumerable<Producto>> GetProductos();
    }
}
