using System.Collections.Generic;
using System.Linq;
using TestBooster24GroupApp.Core.Dto;
using TestBooster24GroupApp.Core.Models;
using TestBooster24GroupApp.Core.Repositories;

namespace TestBooster24GroupApp.Persistence.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationDbContext _context;

        public CityRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetCities()
        {
            return _context.Cities.ToList();
        }
    }
}