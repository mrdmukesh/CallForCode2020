using System.Collections.Generic;
using System.Linq;
using TestBooster24GroupApp.Core.Models;
namespace TestBooster24GroupApp.Core.Repositories
{
    public interface ITestBoosetr24GroupRepository
    {
        IEnumerable<TestBoosetr24Group> GetTestBoosetr24Groups();

        IEnumerable<Patient> GetTestBoosetr24GroupPatient(int id);
        IEnumerable<TestBoosetr24Group> GetRecentTestBoosetr24Groups(int id);
        //IEnumerable<TestBoosetr24Group> GetTestBoosetr24GroupByToken(string searchTerm = null);
        TestBoosetr24Group GetTestBoosetr24Group(int id);
        //IQueryable<TestBoosetr24Group> GetTestBoosetr24GroupsQuery(string query);
        void Add(TestBoosetr24Group testBoosetr24Group);
        void Remove(TestBoosetr24Group testBoosetr24Group);
    }
}