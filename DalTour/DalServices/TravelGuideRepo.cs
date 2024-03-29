using DalTour.DalApi;
using DalTour.DalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DalTour.DalServices
{
    public class TravelGuideRepo : ITravelGuide
    {
        TouristContext context;
        public TravelGuideRepo(TouristContext touristContext)
        {
            context = touristContext;
        }

        public TravelGuide Add(TravelGuide obj)
        {
            if (!context.TravelGuides.Contains(obj))
            {
                context.TravelGuides.Add(obj);
                context.SaveChanges();
                return obj;
            }
            return null;
        }

        public TravelGuide Get(int id)
        {
            return context.TravelGuides.Find(id);
        }

        public List<TravelGuide> GetAll()
        {
            List<TravelGuide> result =context.TravelGuides.ToList();
            return result;
        }
    }
}
