using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Business
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Category { get; set; }

    public int? CityId { get; set; }

    public string Adress { get; set; }

    public string PhoneNum { get; set; }

    public string OpeningHours { get; set; }

    public string MoreInfo { get; set; }

    public int Stars { get; set; }

    public virtual Category CategoryNavigation { get; set; }

    public virtual City City { get; set; }
}
