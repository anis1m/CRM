using CRM.Models;
using CRM.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Controllers
{
    [ApiController]
    [Route("/parts")]
    public class PartsController : ControllerBase
    {
        

        [HttpGet]
        [Route("getallparts")]
        public ActionResult GetAllParts()
        {
            PartsMaster partsMaster = new PartsMaster();
            List<Parts_Master> listofparts= partsMaster.getAll();
            return Ok(listofparts);
        }

        [HttpGet]
        [Route("getallparts/{id}")]
        public ActionResult GetSinglePart(int id)
        {
            PartsMaster partsMaster = new PartsMaster();
            Parts_Master part = partsMaster.getSingle(id);
            return Ok(part);

        }
    }
}
