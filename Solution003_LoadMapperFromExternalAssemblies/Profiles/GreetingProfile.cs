using AutoMapper;
using Services;
using System;

namespace Profiles
{
    public class GreetingProfile : Profile
    {
        public GreetingProfile()
        {
            CreateMap<HelloMessage, GreetingRequest>();
            CreateMap<GreetingResponse, GreetingModel>()
                .ForMember(dest => dest.Id,
                opt => opt.MapFrom(src => Guid.NewGuid().ToString()));
        }
    }
}
