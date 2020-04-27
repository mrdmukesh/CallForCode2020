using System.Data.Entity.ModelConfiguration;
using TestBooster24GroupApp.Core.Models;

namespace TestBooster24GroupApp.Persistence.EntityConfigurations
{
    public class PatientStatusConfiguration : EntityTypeConfiguration<PatientStatus>
    {
        public PatientStatusConfiguration()
        {
            Property(s => s.Name).IsRequired().HasMaxLength(255);
        }
    }
}