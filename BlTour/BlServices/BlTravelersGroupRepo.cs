using BlTour.BlApi;
using BlTour.BlModels;
using DalTour.DalApi;
using DalTour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TouristCompany.DALModels;

namespace BlTour.BlServices
{
    public class BlTravelersGroupRepo : IBlTravelersGroup
    {
        ITravelersGroup travelersGroupInstance;
        public BlTravelersGroupRepo(DalManager dalManager)
        {
            travelersGroupInstance = dalManager.TravelersGroups;
        }
        public BlTravelersGroup Add(BlTravelersGroup item)
        {
            TravelersGroup instance = new TravelersGroup();
            instance.MinAge = item.MinAge;
            instance.MaxAge = item.MaxAge;
            instance.NumberOfMembers = item.NumberOfMembers;
            instance.Destination = item.Destination;
            travelersGroupInstance.Add(instance);
            return item;
        }

        public BlTravelersGroup Get(int id)
        {
            TravelersGroup travelersGroup = travelersGroupInstance.Get(id);
            if (travelersGroup != null)
            {
                BlTravelersGroup blTravelersGroup = new BlTravelersGroup(travelersGroup.Id, travelersGroup.MinAge, travelersGroup.MaxAge, travelersGroup.NumberOfMembers, travelersGroup.Destination, travelersGroup.GuiderId);
                return blTravelersGroup;
            }
            return null;
        }

        public List<BlTravelersGroup> GetAll()
        {

            List<TravelersGroup> dlTravelersGroups = travelersGroupInstance.GetAll();
            List<BlTravelersGroup> blTravelersGroupList = new List<BlTravelersGroup>();
            for (int i = 0; i < dlTravelersGroups.Count; i++)
            {
                blTravelersGroupList.Add(new BlTravelersGroup(dlTravelersGroups[i].Id, dlTravelersGroups[i].MinAge, dlTravelersGroups[i].MaxAge, dlTravelersGroups[i].NumberOfMembers, dlTravelersGroups[i].Destination, dlTravelersGroups[i].GuiderId));
            }
            return blTravelersGroupList;
        }
    }
}