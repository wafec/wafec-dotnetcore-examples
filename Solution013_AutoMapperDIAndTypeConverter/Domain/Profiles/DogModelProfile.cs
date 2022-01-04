using AutoMapper;
using Domain.Converters;
using Domain.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Profiles
{
    public class DogModelProfile : Profile
    {
        public DogModelProfile()
        {
            CreateMap<DogModel, DogEntity>().ConvertUsing<DogModelToEntityTypeConverter>();
        }
    }
}
