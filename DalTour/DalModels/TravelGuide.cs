using System;
using System.Collections.Generic;

namespace DalTour.DalModels;

public partial class TravelGuide
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string MobileNum { get; set; }

    public virtual ICollection<TravelersGroup> TravelersGroups { get; set; } = new List<TravelersGroup>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
