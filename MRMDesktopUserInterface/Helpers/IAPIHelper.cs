using MRMDesktopUserInterface.Models;
using System.Threading.Tasks;

namespace MRMDesktopUserInterface.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticates(string username, string password);
    }
}