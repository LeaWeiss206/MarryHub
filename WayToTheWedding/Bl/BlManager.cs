using Bl.BlApi;
using Bl.BlImplementaion;
using Dal;
using Dal.DalImplementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl;

public class BlManager
{
   
    public ICitiesRepo CitiesRepo { get; set; }
    public ICategoriesRepo CategoriesRepo { get; set; }
    public IBusinessRepo BusinessRepo { get; set; }
    public IHousingUnitsRepo HousingUnitRepo { get; set; }

    public BlManager(string connStr)
    {
        ServiceCollection Services = new ServiceCollection();

        Services.AddAutoMapper(typeof(Profiles.AutoMapperProfile));
        Services.AddSingleton<DalManager>(x=> new DalManager(connStr));

        Services.AddScoped<ICitiesRepo, CitiesRepoBl>();
        Services.AddScoped<ICategoriesRepo, CategoriesRepoBl>();
        Services.AddScoped<IBusinessRepo, BusinessRepoBl>();
        Services.AddScoped<IHousingUnitsRepo, HousingUnitsRepoBl>();

        ServiceProvider provider = Services.BuildServiceProvider(); 

        CategoriesRepo = provider.GetRequiredService<ICategoriesRepo>();
        CitiesRepo = provider.GetRequiredService<ICitiesRepo>();
        BusinessRepo = provider.GetRequiredService<IBusinessRepo>();
        HousingUnitRepo = provider.GetRequiredService<IHousingUnitsRepo>();
    }
}
