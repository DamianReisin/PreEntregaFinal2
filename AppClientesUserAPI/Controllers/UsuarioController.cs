using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace AppClientesUserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public  IEnumerable<Usuario> usuarios() 
        {
           return UsuarioBussines.ListarUsuarios().ToArray();
        }
        [HttpDelete(Name = "EliminarUsuario")]
        public void Delete([FromBody] int id)
        {

        }
        [HttpPut(Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario usuario)
        {

        }
        [HttpPost(Name = "AltaUsuario")]
        public void Post([FromBody] Usuario usuario)
        {

        }


    }
}
