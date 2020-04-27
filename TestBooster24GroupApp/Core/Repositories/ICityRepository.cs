using System.Collections.Generic;
using TestBooster24GroupApp.Core.Models;

namespace TestBooster24GroupApp.Core.Repositories
{
    public interface ICityRepository
    {
        IEnumerable<City> GetCities();
    }
}