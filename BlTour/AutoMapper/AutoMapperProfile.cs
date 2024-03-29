using AutoMapper;
using BlTour.BlModels;
using DalTour;
using DalTour.DalModels;
using DalTour.DalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlTour.AutoMapper
{
    internal class AutoMapperProfile : Profile
    {
        
        public AutoMapperProfile()
        {

            
            CreateMap<TravelGuide,BlTravelGuide>().ReverseMap();
           
            CreateMap<TravelersGroup, BlTravelersGroup>()
                .ForMember(dest => dest.GuiderName, source => source.MapFrom(src => src.Guider.FirstName+" "+ src.Guider.LastName));
            CreateMap<BlTravelersGroup, TravelersGroup>()
                .ForMember(dest => dest.Guider.FirstName, src => src.MapFrom(source=> source.GuiderName.Split(" ")[0]));
        }
    }
}
