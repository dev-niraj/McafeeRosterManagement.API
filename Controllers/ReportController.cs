using System.Threading.Tasks;
using McafeeRosterManagement.API.Models;
using McafeeRosterManagement.API.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace McafeeRosterManagement.API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase {
        private readonly ReportsIRepository _repo;
        private readonly RosterDBContext _context;
        public ReportController (RosterDBContext context) {
            _context = context;
            // _repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> GetReports () {
            var report = (from a in _context.Aschedule
                            join b in _context.Schedule on a.ShId equals b.ShId
                            join c in _context.Users on a.Wwid equals c.Wwid
                        select new {
                            start_date = b.StartDate,
                            end_date = b.EndDate,
                            sid = a.SId,
                            name = c.Name
                        });

            return Ok(report);
        }
    }
}