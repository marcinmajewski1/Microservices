using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Pierwszy klient", "Drugi klient", "Trzeci klient" };
        }
    }
}
