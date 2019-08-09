using System;
using System.Collections.Generic;

namespace McafeeRosterManagement.API.Models
{
    public partial class Schedule
    {
        public Schedule()
        {
            Aschedule = new HashSet<Aschedule>();
        }

        public int ShId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string SchType { get; set; }
        public int? TId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Team T { get; set; }
        public Users User { get; set; }
        public virtual ICollection<Aschedule> Aschedule { get; set; }

    }
}
