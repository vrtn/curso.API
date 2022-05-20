using curso.API.Models;
using curso.API.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace curso.API.Controllers
{
    /// <summary>
    /// Controller do Usuário
    /// </summary>
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /// <summary>
        /// Este serviço permite autenticar um usuário cadastrado e ativo
        /// </summary>
        /// <param name="loginViewModelInput">View Model do login</param>
        /// <returns></returns>
        [SwaggerResponse(statusCode:200, description:"Sucesso ao autenticar o usuário", Type =typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode:400, description:"Campos Obrigatórios",Type =typeof(ValidaCampoViewModelOutput))]
        [SwaggerResponse(statusCode:500, description:"Erro Interno", Type =typeof(ErroGenericoViewModel))]
        [HttpPost]
        [Route("logar")]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        /// <summary>
        /// Este serviço permite cadastrar um usuário
        /// </summary>
        /// <param name="registroViewModelInput">View Model do Registro</param>
        /// <returns></returns>

        [HttpPost]
        [Route("registrar")]
        public IActionResult Registrar(RegistroViewModelInput registroViewModelInput)
        {
            return Created("", registroViewModelInput);
        }
    }
}
