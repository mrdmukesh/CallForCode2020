using System.Collections.Generic;
using TestBooster24GroupApp.Core.Models;

namespace TestBooster24GroupApp.Core.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetDectors();
        IEnumerable<Doctor> GetAvailableDoctors();
        Doctor GetDoctor(int id);
        Doctor GetProfile(string userId);
        void Add(Doctor doctor);
    }
}