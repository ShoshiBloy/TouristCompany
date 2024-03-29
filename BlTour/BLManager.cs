using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BlTour.BlApi;
using BlTour.BlModels;
using BlTour.BlServices;
using DalTour;
//using DalTour.DalApi;
//using DalTour.DalServices;

using Microsoft.Extensions.DependencyInjection;


namespace BlTour
{
    public class BLManager
    {
        public IBlTravelersGroup TravelersGroups { get;}
        public IBlTravelGuide TravelGuides { get; }

        public BLManager()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<DalManager>();
            services.AddScoped<IBlTravelGuide, BlTravelGuideRepo>();

            services.AddScoped<IBlTravelersGroup, BlTravelersGroupRepo>();
            services.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));
            ServiceProvider provider = services.BuildServiceProvider();

            TravelersGroups =provider.GetRequiredService<IBlTravelersGroup>();
            TravelGuides=provider.GetRequiredService<IBlTravelGuide>();
            //provider.GetRequiredService<IBlTravelGuide>();
        }

    }
}
