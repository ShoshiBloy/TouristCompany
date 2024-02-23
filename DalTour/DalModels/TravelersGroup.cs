using System;
using System.Collections.Generic;

namespace TouristCompany.DALModels;

public partial class TravelersGroup
{
    public int Id { get; set; }

    public int MinAge { get; set; }

    public int MaxAge { get; set; }

    public int NumberOfMembers { get; set; }

    public string Destination { get; set; } = null!;

    public string GuiderId { get; set; } = null!;

    public virtual TravelGuide Guider { get; set; } = null!;

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
