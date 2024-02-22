using Bl;
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
        ICitiesRepo CitiesRepo;
        public CitiesController(BlManager blManager)
        {
            CitiesRepo = blManager.CitiesRepo;
        }
        [HttpGet]

        public ActionResult<List<City>> GetAll()
        {
            return CitiesRepo.GetAll();
        }



    }
}
