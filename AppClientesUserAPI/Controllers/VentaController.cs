using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVenta")]
        public IEnumerable<Venta> ventas()
        {
            return VentaBussines.ListarVenta().ToArray();
        }
        
        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] int id)
        {   
            VentaBussines.EliminarVenta(id);
        }
       
        [HttpPut(Name = "ModificarVenta")]
        public void Put([FromBody] Venta venta)
        {
            VentaBussines.ModificarVenta(venta);
        }
        
        [HttpPost(Name = "AltaVenta")]
        public void Post(Venta venta)
        {
            VentaBussines.CrearVenta(venta);
        }

    }
}
