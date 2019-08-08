using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace McafeeRosterManagement.API.Models
{
    public class ReportIndexData
    {
        public IEnumerable<Schedule> Schedule { get; set; }
        public IEnumerable<Aschedule> Aschedules { get; set; }
        public IEnumerable<Users> Users { get; set; }

    }
}