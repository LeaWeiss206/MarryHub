using Dal.DalApi;
using Dal.DalImplementation;
using Dal.Models;
using Microsoft.EntityFrameworkCore;
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

    public DalManager(string connStr)
    {
        ServiceCollection Services = new ServiceCollection();

        Services.AddSingleton<SiteContext>();
        Services.AddScoped<ICitiesRepo, CitiesRepo>();
        Services.AddScoped<ICategoriesRepo, CategoriesRepo>();

        Services.AddDbContext<SiteContext>(opt => opt.UseSqlServer(connStr));

        ServiceProvider provider = Services.BuildServiceProvider();

        CategoriesRepo = provider.GetRequiredService<ICategoriesRepo>();
        CitiesRepo = provider.GetRequiredService<ICitiesRepo>();
    }
}
