using DalTour.DalApi;
using DalTour.DalModels;
using DalTour.DalServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DalTour
{
    public class DalManager
    {
        public ITravelersGroup TravelersGroups { get; set; }
        public ITravelGuide TravelGuides { get; set; }
        public DalManager() {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<TouristContext>();
            services.AddScoped<ITravelersGroup, TravelserGroupRepo>();
            services.AddScoped<ITravelGuide, TravelGuideRepo>();

            ServiceProvider servicesProvider = services.BuildServiceProvider();
            TravelersGroups= servicesProvider.GetService<ITravelersGroup>();
            TravelGuides= servicesProvider.GetService<ITravelGuide>();

        }
    }
}
