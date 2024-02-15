using Bl.BlApi;
using Bl.BlImplementaion;
using Bl.Bo;
using Dal.DalImplementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        ICitiesRepo iCitiesRepo;
        public CitiesController(ICitiesRepo iCitiesRepo)
        {
            this.iCitiesRepo = iCitiesRepo;
        }
        [HttpGet]
        public ActionResult<List<City>> GetAll()
        {
            return iCitiesRepo.GetAll();
        }



    }
}
