
using Mapster;
using Task_Manager.Contracts.Responces;

namespace Task_Manager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class User : ControllerBase
    {
        private readonly IServiceUser _serviceUser;

        public User(IServiceUser serviceUser)
        {
            this._serviceUser = serviceUser;
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            var responce= await _serviceUser.GetAll();
            var responcemapping = responce.Adapt<List<UserResponce>>();
            if (responcemapping != null){ return Ok(responcemapping);}
            else{ return NotFound(responcemapping); }
        }

    }
}
