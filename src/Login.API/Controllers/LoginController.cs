using System;
using System.Threading.Tasks;
using Login.API.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace Login.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginAppService _loginAppService;

        public LoginController(ILoginAppService loginAppService)
        {
            this._loginAppService = loginAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(PessoaViewModel pessoaViewModel)
        {
            try
            {
                return new JsonResult(await _loginAppService.Login(pessoaViewModel));
            }
            catch (Exception ex)
            {
                if (ex.Message == "Object reference not set to an instance of an object.") return StatusCode(500, "Internal error.");
                return StatusCode(500, "Error: " + ex.Message);
            }
        }
    }
}