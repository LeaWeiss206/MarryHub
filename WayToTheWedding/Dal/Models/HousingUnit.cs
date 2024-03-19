using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class HousingUnit
{
    public int Id { get; set; }

    public int CityId { get; set; }

    public string PhoneNum { get; set; }

    public string Adress { get; set; }

    public int Mr { get; set; }

    public string Name { get; set; }

    public virtual City City { get; set; }
}
