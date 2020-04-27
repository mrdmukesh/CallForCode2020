using TestBooster24GroupApp.Core.Repositories;

namespace TestBooster24GroupApp.Core
{
    public interface IUnitOfWork
    {
        IPatientRepository Patients { get; }
        IAppointmentRepository Appointments { get; }
        IAttendanceRepository Attandences { get; }
        ICityRepository Cities { get; }
        IDoctorRepository Doctors { get; }
        ISpecializationRepository Specializations { get; }
        IApplicationUserRepository Users { get; }

        ITestBoosetr24GroupRepository TestBoosetr24Groups { get; }

        void Complete();
    }
}