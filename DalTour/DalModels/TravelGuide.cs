using System;
using System.Collections.Generic;

namespace TouristCompany.DALModels;

public partial class TravelGuide
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string MobileNum { get; set; } = null!;

    public virtual ICollection<TravelersGroup> TravelersGroups { get; set; } = new List<TravelersGroup>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
