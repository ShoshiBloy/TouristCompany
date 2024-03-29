using DalTour.DalApi;
using DalTour.DalModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TouristCompany.DALModels;

namespace DalTour.DalServices
{
    public class TravelserGroupRepo : ITravelersGroup
    {
        TouristContext context;
        public TravelserGroupRepo(TouristContext touristContext)
        {
            context = touristContext;
        }
        public TravelersGroup Add(TravelersGroup obj)
        {
            if (!context.TravelersGroups.Contains(obj)) { 
                context.TravelersGroups.Add(obj);
                context.SaveChanges();
                return obj;
            }
            return null;
        }

        public TravelersGroup Get(int id)
        {
            return context.TravelersGroups.Find(id);
        }

        public List<TravelersGroup> GetAll()
        {
            List<TravelersGroup> result=context.TravelersGroups.Include(t=>t.Guider).ToList();
            return result;
        }
    }
}
