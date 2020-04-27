using TestBooster24GroupApp.Core.Models;
using TestBooster24GroupApp.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace TestBooster24GroupApp.Persistence.Repositories
{
    public class SpecializationRepository : ISpecializationRepository
    {
        public readonly ApplicationDbContext Context;

        public SpecializationRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public IEnumerable<Specialization> GetSpecializations()
        {
            return Context.Specializations.ToList();
        }
    }
}