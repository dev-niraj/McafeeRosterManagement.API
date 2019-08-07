using System;
using System.Collections.Generic;

namespace McafeeRosterManagement.API.Models
{
    public partial class UsersHistory
    {
        public int SlNo { get; set; }
        public int? Wwid { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int? TId { get; set; }
        public string Type { get; set; }
        public int? BuId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Users Ww { get; set; }
    }
}
