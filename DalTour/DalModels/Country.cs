using System;
using System.Collections.Generic;

namespace TouristCompany.DALModels;

public partial class Country
{
    public int Id { get; set; }

    public string CountryName { get; set; } = null!;

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
