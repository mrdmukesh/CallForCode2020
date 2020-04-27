using TestBooster24GroupApp.Core.Models;
using TestBooster24GroupApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestBooster24GroupApp.Persistence.Repositories
{
    public class TestBoosetr24GroupRepository : ITestBoosetr24GroupRepository
    {
        private readonly ApplicationDbContext _context;
        public TestBoosetr24GroupRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Get all patients
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TestBoosetr24Group> GetTestBoosetr24Groups()
        {
            return _context.TestBoosetr24Groups;
        }

        /// <summary>
        /// /Get single patient
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TestBoosetr24Group GetTestBoosetr24Group(int id)
        {
            return _context.TestBoosetr24Groups
                .SingleOrDefault(p => p.Id == id);
            //return _context.Patients.Find(id);
        }

        public IEnumerable<Patient>  GetTestBoosetr24GroupPatient(int id)
        {
            return _context.Patients.Where(p => p.TestGId == id).DefaultIfEmpty();
            //return _context.Patients.Find(id);
        }
        /// <summary>
        /// Get newly added patients
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TestBoosetr24Group> GetRecentTestBoosetr24Groups()
        {
            return _context.TestBoosetr24Groups
                .Where(a => DbFunctions.DiffDays(a.CreationDate, DateTime.Now) == 0);
                
        }



        /// <summary>
        /// Add new testBoosetr24Group
        /// </summary>
        /// <param name="testBoosetr24Group"></param>
        public void Add(TestBoosetr24Group testBoosetr24Group)
        {
            _context.TestBoosetr24Groups.Add(testBoosetr24Group);
        }
        /// <summary>
        /// Delete existing testBoosetr24Group
        /// </summary>
        /// <param name="testBoosetr24Group"></param>
        public void Remove(TestBoosetr24Group testBoosetr24Group)
        {
            _context.TestBoosetr24Groups.Remove(testBoosetr24Group);
        }

        public IEnumerable<TestBoosetr24Group> GetRecentTestBoosetr24Groups(int id)
        {
            throw new NotImplementedException();
        }
    }
}