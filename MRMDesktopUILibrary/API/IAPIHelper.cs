using MRMDesktopUILibrary.Models;
using System.Threading.Tasks;

namespace MRMDesktopUILibrary.API
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticates(string username, string password);
        Task GetLoggedInUsreInfo(string token);
    }
}