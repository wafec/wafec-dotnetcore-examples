using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi01.Data.Contexts;
using WebApi01.Data.Entities;

namespace WebApi01.Data.Repositories
{
    public class PetRepository
    {
        private PetShopContext _context;

        public PetRepository(PetShopContext context) => this._context = context;

        public IEnumerable<PetEntity> GetAll()
        {
            return this._context.Pets.AsEnumerable();
        }

        public void Add(PetEntity pet)
        {
            this._context.Pets.Add(pet);
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }
    }
}
