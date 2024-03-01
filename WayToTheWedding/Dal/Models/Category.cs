using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Business> Businesses { get; set; } = new List<Business>();
}
