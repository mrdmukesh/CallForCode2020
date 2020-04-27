using System.Data.Entity.ModelConfiguration;
using TestBooster24GroupApp.Core.Models;
namespace TestBooster24GroupApp.Persistence.EntityConfigurations
{
    public class TestBoosetr24GroupConfiguration : EntityTypeConfiguration<TestBoosetr24Group>
    {
        public TestBoosetr24GroupConfiguration()
        {
            Property(g => g.CityId).IsRequired();
            Property(g => g.Id).IsRequired();
            Property(g => g.Name).IsRequired().HasMaxLength(255);
            Property(g => g.GroupOwnerId).IsRequired();
            Property(g => g.Address).IsRequired().HasMaxLength(255);
            Property(g => g.CreationDate).IsRequired();
            Property(g => g.Token).IsRequired();
            Property(g => g.Doctor).IsRequired();
            Property(g => g.TestStatus).IsRequired();
            HasMany(g => g.Patients);
        }
    }
}