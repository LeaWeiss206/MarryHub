using Bl.BlApi;
using Bl.Bo;
using Microsoft.AspNetCore.Mvc;


namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController
{
    ICategoriesRepo icategoriesRepo;

    public CategoriesController(ICategoriesRepo icategoriesRepo)
    {

      this.icategoriesRepo = icategoriesRepo;

    }
   [HttpGet]
    public ActionResult<List<Category>> GetAll()
    {
        return icategoriesRepo.GetAll();
    }

}
