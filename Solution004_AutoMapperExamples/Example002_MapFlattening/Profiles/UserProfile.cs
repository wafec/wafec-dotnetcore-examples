using AutoMapper;
using Example002_MapFlattening.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example002_MapFlattening.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().IncludeMembers(s => s.Details);
            CreateMap<UserDetails, UserDto>(MemberList.Source);
        }
    }
}
