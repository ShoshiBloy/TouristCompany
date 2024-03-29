using System;
using System.Collections.Generic;

namespace DalTour.DalModels;

public partial class Site
{
    public int Id { get; set; }

    public string Description { get; set; }

    public int CountryId { get; set; }

    public virtual ICollection<SitesToTrip> SitesToTrips { get; set; } = new List<SitesToTrip>();
}
