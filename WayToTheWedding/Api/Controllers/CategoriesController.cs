using Bl;
using Bl.BlApi;
using Bl.Bo;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController
{
    ICategoriesRepo categoriesRepo;

    public CategoriesController(BlManager blManager)
    {

      categoriesRepo = blManager.CategoriesRepo;

    }
   [HttpGet]
    public ActionResult<List<Category>> GetAll()
    {
        return categoriesRepo.GetAll();
    }

}
