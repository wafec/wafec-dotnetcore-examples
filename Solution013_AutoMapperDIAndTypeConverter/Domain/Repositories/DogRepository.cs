using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class DogRepository : IDogRepository
    {
        private static readonly DogEntity[] dogs = new DogEntity[]
        {
            new DogEntity {Id = 1, Name = "Loo", Age = 3},
            new DogEntity {Id = 2, Name = "Rex", Age = 5}
        };

        public Task<IEnumerable<DogEntity>> GetByName(string dogName)
        {
            return Task.FromResult(dogs.Where(d => d.Name.Equals(dogName)));
        }
    }
}
