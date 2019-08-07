using System;
using System.Collections.Generic;

namespace McafeeRosterManagement.API.Models
{
    public partial class WeekOff
    {
        public WeekOff()
        {
            Aschedule = new HashSet<Aschedule>();
        }

        public int WoId { get; set; }
        public int? Wo1 { get; set; }
        public int? Wo2 { get; set; }
        public string WorkDays { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual ICollection<Aschedule> Aschedule { get; set; }
    }
}
