using System;
using System.Collections.Generic;

namespace DalTour.DalModels;

public partial class SitesToTrip
{
    public int Id { get; set; }

    public int SiteId { get; set; }

    public int TripId { get; set; }

    public virtual Site Site { get; set; }

    public virtual Trip Trip { get; set; }
}
