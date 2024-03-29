using System;
using System.Collections.Generic;

namespace DalTour.DalModels;

public partial class TravelersGroup
{
    public int Id { get; set; }

    public int MinAge { get; set; }

    public int MaxAge { get; set; }

    public int NumberOfMembers { get; set; }

    public string Destination { get; set; }

    public int GuiderId { get; set; }

    public virtual TravelGuide Guider { get; set; }

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
