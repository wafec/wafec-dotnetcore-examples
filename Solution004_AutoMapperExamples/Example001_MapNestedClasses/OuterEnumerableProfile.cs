using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example001_MapNestedClasses
{
    public class OuterEnumerableProfile : Profile
    {
        public OuterEnumerableProfile()
        {
            CreateMap<OuterSourceEnumerable, OuterDestEnumerable>();
            CreateMap<InnerSourceEnumerable, InnerDestEnumerable>();
        }
    }
}
