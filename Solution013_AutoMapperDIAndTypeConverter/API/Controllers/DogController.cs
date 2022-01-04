using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DogController
    {
        private IMapper _mapper;

        public DogController(IMapper mapper)
        {
            this._mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post(DogModel dogModel)
        {
            return new JsonResult(this._mapper.Map<DogEntity>(dogModel));
        }
    }
}
