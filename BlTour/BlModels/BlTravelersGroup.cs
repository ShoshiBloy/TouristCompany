using DalTour.DalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlTour.BlModels
{
    public class BlTravelersGroup
    {
        //TravelGuideRepo travelGuideRepo;
        public int Id { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public int NumberOfMembers { get; set; }

        public string Destination { get; set; } = null!;
        public int GuiderId { get; set; }
        public string GuiderName { get; set; }
        

        //public BlTravelersGroup(int id, int minAge, int maxAge, int numberOfMembers, string destination, int guiderId)
        //{
        //    Id = id;
        //    MinAge = minAge;
        //    MaxAge = maxAge;
        //    NumberOfMembers = numberOfMembers;
        //    Destination = destination;
        //    GuiderName = travelGuideRepo.GetAll().FirstOrDefault(GId => Equals(GId.Id, guiderId)).FirstName+" "+ travelGuideRepo.GetAll().FirstOrDefault(GId => Equals(GId.Id, guiderId)).LastName.ToString();

        //}

    }
}
