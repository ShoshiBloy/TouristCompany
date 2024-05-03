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

namespace BlTour.AutoMapper;
 internal class AutoMapperProfile : Profile
    {
    TravelGuideRepo TravelGuideRepo;
    public string GetFirstName(string source)=> source.Split(' ')[0];
        public string GetLastName(string source) => source.Split(' ')[1];
        public AutoMapperProfile()
        {
            
            
            CreateMap<TravelGuide,BlTravelGuide>().ReverseMap();
           
            CreateMap<TravelersGroup, BlTravelersGroup>()
                .ForMember(dest => dest.GuiderName, source => source.MapFrom(src => $"{src.Guider.FirstName} {src.Guider.LastName}"));
            CreateMap<BlTravelersGroup, TravelersGroup>()
                .ForPath(dest => dest.Guider.FirstName, src => src.MapFrom(source=> GetFirstName(source.GuiderName)))
            .ForPath(dest => dest.Guider.LastName, src => src.MapFrom(source => GetLastName(source.GuiderName)))
            //.ForPath(dest=>dest.Guider,src=>src.MapFrom(source=>TravelGuideRepo.GetAll().Find()
            ;

        }
    }
