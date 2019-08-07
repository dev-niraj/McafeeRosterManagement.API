using System;
using System.Collections.Generic;

namespace McafeeRosterManagement.API.Models
{
    public partial class Businessunit
    {
        public Businessunit()
        {
            Team = new HashSet<Team>();
            Users = new HashSet<Users>();
        }

        public int BuId { get; set; }
        public string BuName { get; set; }
        public string BuDescription { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual ICollection<Team> Team { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
