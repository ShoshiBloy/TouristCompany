using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlTour.BlModels
{
    public class BlTravelGuide
    {
        public string Id { get; set; } = null!;

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string MobileNum { get; set; } = null!;
        public BlTravelGuide(string id, string firstName, string lastName, string mobileNum)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MobileNum = mobileNum;
        }
    }
}
