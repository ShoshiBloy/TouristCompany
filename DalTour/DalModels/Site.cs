using System;
using System.Collections.Generic;

namespace TouristCompany.DALModels;

public partial class Site
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public int CountryId { get; set; }

    public virtual ICollection<SitesToTrip> SitesToTrips { get; set; } = new List<SitesToTrip>();
}
