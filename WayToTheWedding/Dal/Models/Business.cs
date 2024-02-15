using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Business
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Category { get; set; }

    public int? CityId { get; set; }

    public string? Adress { get; set; }

    public string PhoneNum { get; set; } = null!;

    public string? OpeningHours { get; set; }

    public string? MoreInfo { get; set; }

    public virtual Category CategoryNavigation { get; set; } = null!;

    public virtual City? City { get; set; }
}
