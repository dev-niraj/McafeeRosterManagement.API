using System.Collections.Generic;
using System.Threading.Tasks;
using McafeeRosterManagement.API.Models;

namespace McafeeRosterManagement.API.Repository
{
    public interface ReportsIRepository
    {
        // Task<IEnumerable<Schedule>> GetReport();
        Task<IEnumerable<Aschedule>> GetReport();
        
    }
}