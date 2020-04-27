using System.Collections.Generic;
using TestBooster24GroupApp.Core.Models;
using TestBooster24GroupApp.Core.ViewModel;

namespace TestBooster24GroupApp.Core.Repositories
{
    public interface IApplicationUserRepository
    {
        List<UserViewModel> GetUsers();
        ApplicationUser GetUser(string id);
    }
}