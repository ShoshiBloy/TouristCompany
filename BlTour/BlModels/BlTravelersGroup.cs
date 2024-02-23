using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlTour.BlModels
{
    public class BlTravelersGroup
    {
        public int Id { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public int NumberOfMembers { get; set; }

        public string Destination { get; set; } = null!;
        public string GuiderName { get; set; }

    }
}
