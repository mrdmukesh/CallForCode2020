using System.Data.Entity.ModelConfiguration;
using TestBooster24GroupApp.Core.Models;

namespace TestBooster24GroupApp.Persistence.EntityConfigurations
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            Property(p => p.Name).IsRequired().HasMaxLength(255);
        }
    }
}