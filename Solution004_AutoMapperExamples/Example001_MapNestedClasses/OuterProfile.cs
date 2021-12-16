using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example001_MapNestedClasses
{
    public class OuterProfile : Profile
    {
        public OuterProfile()
        {
            CreateMap<OuterSource, OuterDest>();
            CreateMap<InnerSource, InnerDest>();
        }
    }
}
