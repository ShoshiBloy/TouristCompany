using System;
using System.Collections.Generic;

namespace TouristCompany.DALModels;

public partial class Trip
{
    public int Id { get; set; }

    public string GuiderId { get; set; } = null!;

    public int GroupId { get; set; }

    public DateTime BeginningTime { get; set; }

    public DateTime EndTime { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual TravelersGroup Group { get; set; } = null!;

    public virtual TravelGuide Guider { get; set; } = null!;

    public virtual ICollection<SitesToTrip> SitesToTrips { get; set; } = new List<SitesToTrip>();
}
