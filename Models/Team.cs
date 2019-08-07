using System;
using System.Collections.Generic;

namespace McafeeRosterManagement.API.Models
{
    public partial class Team
    {
        public Team()
        {
            Oncall = new HashSet<Oncall>();
            Schedule = new HashSet<Schedule>();
            Swap = new HashSet<Swap>();
            Users = new HashSet<Users>();
        }

        public int TId { get; set; }
        public string TName { get; set; }
        public int? MgrId { get; set; }
        public int? BuId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Businessunit Bu { get; set; }
        public virtual ICollection<Oncall> Oncall { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }
        public virtual ICollection<Swap> Swap { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
