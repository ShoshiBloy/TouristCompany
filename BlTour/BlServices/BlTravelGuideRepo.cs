using AutoMapper;
using BlTour.BlApi;
using BlTour.BlModels;
using DalTour;
using DalTour.DalApi;
using DalTour.DalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TouristCompany.DALModels;


namespace BlTour.BlServices
{
    public class BlTravelGuideRepo : IBlTravelGuide
    {
        ITravelGuide travelGuide;
        IMapper map;
        public BlTravelGuideRepo(DalManager dalManager, IMapper _map)
        {
            this.travelGuide = dalManager.TravelGuides;
            this.map = _map;
        }
        public BlTravelGuide Add(BlTravelGuide item)
        {
            TravelGuide instance = map.Map<TravelGuide>(item);
            
            //instance.Id = item.Id;
            //instance.FirstName = item.FirstName;
            //instance.LastName = item.LastName;
            //instance.MobileNum = item.MobileNum;
            travelGuide.Add(instance);

            return item;
        }


        public BlTravelGuide Get(int id)
        {
            TravelGuide travelGuideInstance = travelGuide.Get(id);
            if (travelGuideInstance != null)
            {
                BlTravelGuide blTravelGuide = map.Map<BlTravelGuide>(travelGuideInstance);
                return blTravelGuide;
            }

            return null;
        }

            public List<BlTravelGuide> GetAll()
        {
            List<TravelGuide> travelGuideList = travelGuide.GetAll();
            List<BlTravelGuide> blTravelGuideList = new List<BlTravelGuide>();
            //for (int i = 0; i < travelGuideList.Count; i++)
            //{
            //    blTravelGuideList.Add(new BlTravelGuide(travelGuideList[i].Id, travelGuideList[i].FirstName, travelGuideList[i].LastName, travelGuideList[i].MobileNum));
            //}
            travelGuideList.ForEach(tgr => blTravelGuideList.Add(map.Map<BlTravelGuide>(tgr)));
            return blTravelGuideList;
        }
    }
}