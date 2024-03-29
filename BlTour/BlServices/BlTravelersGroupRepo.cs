using BlTour.BlApi;
using BlTour.BlModels;
using DalTour;
using DalTour.DalApi;
using DalTour.DalModels;
using AutoMapper;
using DalTour.DalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlTour.BlServices
{
    public class BlTravelersGroupRepo : IBlTravelersGroup
    {
        ITravelersGroup travelersGroupInstance;
        IMapper map;
        public BlTravelersGroupRepo(DalManager dalManager , IMapper _map)
        {
            travelersGroupInstance = dalManager.TravelersGroups;
            map = _map;
        }
        public BlTravelersGroup Add(BlTravelersGroup item)
        {
            TravelersGroup instance = map.Map<TravelersGroup>(item);
            //instance.MinAge = item.MinAge;
            //instance.MaxAge = item.MaxAge;
            //instance.NumberOfMembers = item.NumberOfMembers;
            //instance.Destination= item.Destination;
            travelersGroupInstance.Add(instance);
            return item;
        }

        public BlTravelersGroup Get(int id)
        {
            TravelersGroup travelersGroup = travelersGroupInstance.Get(id);
            if (travelersGroup != null)
            {
                BlTravelersGroup blTravelersGroup =map.Map<BlTravelersGroup>(travelersGroup);
                return blTravelersGroup;
            }
            return null;
        }

        public List<BlTravelersGroup> GetAll()
        {

            List<TravelersGroup> dlTravelersGroups = travelersGroupInstance.GetAll();
            List<BlTravelersGroup> blTravelersGroupList = new List<BlTravelersGroup>();
            //for (int i = 0; i < dlTravelersGroups.Count; i++)
            //{
            //    blTravelersGroupList.Add(new BlTravelersGroup(dlTravelersGroups[i].Id, dlTravelersGroups[i].MinAge, dlTravelersGroups[i].MaxAge, dlTravelersGroups[i].NumberOfMembers, dlTravelersGroups[i].Destination, dlTravelersGroups[i].GuiderId));
            //}
            dlTravelersGroups.ForEach(tgr => blTravelersGroupList.Add(map.Map<BlTravelersGroup>(tgr)));
            return blTravelersGroupList;
            
        }
    }
}