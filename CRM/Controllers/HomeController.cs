using CRM.Connection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace CRM.Controllers
{
    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        
        [Route("/")]
        [HttpGet]
        public ActionResult Index()
        {
            return Ok("Hello World");
        }
    }
}
