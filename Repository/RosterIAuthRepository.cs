using System.Threading.Tasks;
using McafeeRosterManagement.API.Models;

namespace McafeeRosterManagement.API.Repository
{
    public interface RosterIAuthRepository
    {
         Task<Users> Register(Users users, string password);
         Task<Users> Login(string email, string password);
         Task<bool> UserExists(string email);
    }
}