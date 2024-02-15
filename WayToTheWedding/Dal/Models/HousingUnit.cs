using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class HousingUnit
{
    public int Id { get; set; }

    public int CityId { get; set; }

    public string PhoneNum { get; set; } = null!;

    public string Adress { get; set; } = null!;

    public int Mr { get; set; }

    public string Name { get; set; } = null!;

    public virtual City City { get; set; } = null!;
}
