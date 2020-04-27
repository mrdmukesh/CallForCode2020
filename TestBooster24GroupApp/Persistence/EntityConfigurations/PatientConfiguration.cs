using System.Data.Entity.ModelConfiguration;
using TestBooster24GroupApp.Core.Models;

namespace TestBooster24GroupApp.Persistence.EntityConfigurations
{
    public class PatientConfiguration : EntityTypeConfiguration<Patient>
    {
        public PatientConfiguration()
        {
            Property(p => p.CityId).IsRequired();
            Property(p => p.TestGId).IsRequired();           
            Property(p => p.Name).IsRequired().HasMaxLength(255);
            Property(p => p.Phone).IsRequired().HasMaxLength(255);
            Property(p => p.Address).IsRequired().HasMaxLength(255);
            Property(p => p.BirthDate).IsRequired();
            Property(p => p.Token).IsRequired();
            //HasMany(p => p.Appointments)
            //    .WithRequired(a => a.Patient)
                //.WillCascadeOnDelete(false);
        }
    }
}