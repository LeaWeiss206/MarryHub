using Bl;
using Bl.BlApi;
using Bl.Bo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        IBusinessRepo BusinessRepo;
        public BusinessController(BlManager blManager)
        {
            BusinessRepo = blManager.BusinessRepo;
        }
        [HttpGet]
        public ActionResult<List<Business>> Get()
        {
            return BusinessRepo.GetAll();
        }
        [HttpPost]
        public ActionResult<Business> Post(Business business)
        {
            if (business == null)
            {
                return BadRequest("The object was not received");
            }
            BusinessRepo.Create(business);
            return business;
        }

    }
}
