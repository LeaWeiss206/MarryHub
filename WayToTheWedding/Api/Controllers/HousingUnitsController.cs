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
            HousingUnitRepo= blManager.HousingUnitRepo;
        }
        [HttpGet]
        public ActionResult<List<HousingUnit>> GetAll()
        {
            return HousingUnitRepo.GetAll();
        }
    }
}
