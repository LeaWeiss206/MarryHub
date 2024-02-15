using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class City
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Business> Businesses { get; set; } = new List<Business>();

    public virtual ICollection<HousingUnit> HousingUnits { get; set; } = new List<HousingUnit>();
}
