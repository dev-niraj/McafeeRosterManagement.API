using System;
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

        public async Task<IEnumerable<Aschedule>> GetReport()
        {
           var report = (from a in _context.Aschedule
                            join b in _context.Schedule on a.ShId equals b.ShId
                            join c in _context.Users on a.Wwid equals c.Wwid
                        select new {
                            start_date = b.StartDate,
                            end_date = b.EndDate,
                            sid = a.SId,
                            name = c.Name
                        });

            // System.Collections.Generic.Ien reports = report.AsEnumerable();
            
            // foreach (var item in report) {
            //     st = item.ToString();
            // }
            // return st.ToList();

            return null;
        }
    }
}