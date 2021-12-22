using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi01.Data.Entities;

namespace WebApi01.Models.Profiles
{
    public class PetEntityProfile : Profile
    {
        public PetEntityProfile()
        {
            CreateMap<PetEntity, PetModel>();
        }
    }
}
