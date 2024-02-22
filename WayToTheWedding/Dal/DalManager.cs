using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal;

public class DalManager
{
    public ICategoriesRepo CategoriesRepo { get; set; }
    public ICitiesRepo CitiesRepo { get; set; }

    public DalManager()
    {
        ServiceCollection Services = new ServiceCollection();

        Services.AddSingleton<SiteContext>();
        Services.AddScoped<ICitiesRepo, CitiesRepo>();
        Services.AddScoped<ICategoriesRepo,CategoriesRepo>();

        ServiceProvider provider = Services.BuildServiceProvider();  // מנהל את האוסף, כאשר משהו מבקש אוביקט הוא אחראי לתת

        CategoriesRepo = provider.GetRequiredService<ICategoriesRepo>();
        CitiesRepo = provider.GetRequiredService<ICitiesRepo>();
    }
}
