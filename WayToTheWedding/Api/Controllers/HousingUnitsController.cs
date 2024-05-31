using Bl;
using Bl.BlApi;
using Bl.Bo;
using Dal.DalImplementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousingUnitsController : ControllerBase
    {
        IHousingUnitsRepo HousingUnitRepo;
        public HousingUnitsController(BlManager blManager)
        {
            HousingUnitRepo = blManager.HousingUnitRepo;
        }
        [HttpGet]
        public ActionResult<List<HousingUnit>> GetAll()
        {
            return HousingUnitRepo.GetAll();
        }

        [HttpPost("{name}")]
        public ActionResult<HousingUnit> Post(string name,HousingUnit housingUnit)
        {
            if(housingUnit == null)
            {
                return BadRequest("The object was not received");
            }
            return HousingUnitRepo.CreateUnit(housingUnit, name);
        }
       
    }
}
