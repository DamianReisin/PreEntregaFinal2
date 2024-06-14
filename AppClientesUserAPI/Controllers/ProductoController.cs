using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> productos()
        {
            return ProductoBussines.ListarProducto().ToArray();
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete()
        {

        }
        [HttpPut(Name = "ModificarProducto")]
        public void Put(Producto producto)
        {

        }
        [HttpPost(Name = "AltaProducto")]
        public void Post(Producto producto)
        {

        }

    }
}
