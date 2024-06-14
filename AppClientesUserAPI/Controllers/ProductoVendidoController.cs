using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "GetProductoVendido")]
        public IEnumerable<ProductoVendido> productosVendidos()
        {
            return ProductoVendidoBussines.ListarProductoVendido().ToArray();
        }
        [HttpDelete(Name = "EliminarProductoVendido")]
        public void Delete()
        {

        }
        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put(ProductoVendido productoVendido)
        {

        }
        [HttpPost(Name = "AltaCliente")]
        public void Post(ProductoVendido productoVendido) 
        {
        
        }



    }
}
