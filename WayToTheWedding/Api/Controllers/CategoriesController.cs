using Bl.BlApi;
using Bl.Bo;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController
{
    ICitiesRepo iCitiesRepo;

    public CategoriesController(ICitiesRepo iCitiesRepo)
    {

        this.iCitiesRepo = iCitiesRepo;

    }
   [HttpGet]
    public ActionResult<List<Category>> GetAll()
    {
        return iCitiesRepo.GetAll();
    }

}
