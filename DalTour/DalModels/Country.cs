using System;
using System.Collections.Generic;

namespace DalTour.DalModels;

public partial class Country
{
    public int Id { get; set; }

    public string CountryName { get; set; }

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
