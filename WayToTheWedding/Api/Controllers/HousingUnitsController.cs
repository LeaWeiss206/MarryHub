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

        [HttpGet("{cityId}")]
        public ActionResult<List<HousingUnit>> GetByCity(int cityId)
        {
            return HousingUnitRepo.GetByCity(cityId);
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
        [HttpPut("{id}")]
        public ActionResult<HousingUnit> Put( HousingUnit housingUnit,int id)
        {
            if (housingUnit == null)
            {
                return BadRequest("The object was not correct");
            }
            if(id < 0) 
            {
                return BadRequest("The id is not ");
            }

            return HousingUnitRepo.Update(id,housingUnit);
        }
        [HttpDelete("{id}")]
        public ActionResult<HousingUnit> Delete(int id)
        {
            if (id < 0)
            {
                return BadRequest("The id is not ");
            }

            return HousingUnitRepo.Delete(id);
        }

    }
}
