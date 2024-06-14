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
        [HttpGet("Filter")]
        public ActionResult<List<Business>> GetByCityAndCategory(int city, int category)
        {
            return BusinessRepo.GetByCityAndCategory(city, category);
        }

        [HttpPost]
        public ActionResult<Business> Post(Business business)
        {
            if (business == null)
            {
                return BadRequest("The object was not received");
            }

            return BusinessRepo.Create(business); 
        }

        [HttpPut("{id}")]
        public ActionResult<Business> Put(int id, Business business)
        {
            if (business == null)
            {
                return BadRequest("The object was not received");
            }
            if (id < 0)
            {
                return BadRequest("The ID is not correct");
            }
            
            return BusinessRepo.Update(id, business);
        }

        [HttpDelete("{id}")]
        public ActionResult<Business> Delete(int id)
        {
            if (id < 0)
            {
                return BadRequest("The ID is not correct");
            }
            return BusinessRepo.Delete(id);
        }



    }
}
