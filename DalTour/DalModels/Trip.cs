using System;
using System.Collections.Generic;

namespace DalTour.DalModels;

public partial class Trip
{
    public int Id { get; set; }

    public int GuiderId { get; set; }

    public int GroupId { get; set; }

    public DateTime BeginningTime { get; set; }

    public DateTime EndTime { get; set; }

    public int CountryId { get; set; }

    public virtual Country Country { get; set; }

    public virtual TravelersGroup Group { get; set; }

    public virtual TravelGuide Guider { get; set; }

    public virtual ICollection<SitesToTrip> SitesToTrips { get; set; } = new List<SitesToTrip>();
}
