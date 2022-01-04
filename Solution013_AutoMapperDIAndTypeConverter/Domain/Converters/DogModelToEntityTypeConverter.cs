using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Converters
{
    public class DogModelToEntityTypeConverter : ITypeConverter<DogModel, DogEntity>
    {
        private readonly IDogRepository _dogRepository;

        public DogModelToEntityTypeConverter(IDogRepository dogRepository)
        {
            this._dogRepository = dogRepository;
        }

        public DogEntity Convert(DogModel source, DogEntity destination, ResolutionContext context)
        {
            return this._dogRepository.GetByName(source.Name).Result.FirstOrDefault();
        }
    }
}
