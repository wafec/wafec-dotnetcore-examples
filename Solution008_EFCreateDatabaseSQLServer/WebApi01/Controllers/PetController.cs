using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi01.Data.Entities;
using WebApi01.Data.Repositories;
using WebApi01.Models;

namespace WebApi01.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetController
    {
        private PetRepository _petRepository;
        private IMapper _mapper;

        public PetController(PetRepository petRepository, IMapper mapper)
        {
            this._petRepository = petRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var petEntities = this._petRepository.GetAll();
            var petModels = petEntities.Select(petEntity => this._mapper.Map<PetModel>(petEntity));
            return new JsonResult(petModels);
        }

        [HttpPost]
        public IActionResult Post(PetModel petModel)
        {
            var petEntity = this._mapper.Map<PetEntity>(petModel);
            this._petRepository.Add(petEntity);
            this._petRepository.SaveChanges();
            return new OkResult();
        }
    }
}
