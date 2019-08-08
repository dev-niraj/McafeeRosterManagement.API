using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using McafeeRosterManagement.API.Models;
using Microsoft.EntityFrameworkCore;

namespace McafeeRosterManagement.API.Repository
{
    public class ReportsRepository : ReportsIRepository
    {
        private readonly RosterDBContext _context;
        public ReportsRepository(RosterDBContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<Schedule>> GetReport()
        {
            var report = await _context.Schedule.Include(p => p.Aschedule).Include(p => p.).ToListAsync();
            return report;
        }
    }
}