using System;
using System.Collections.Generic;

namespace McafeeRosterManagement.API.Models
{
    public partial class Aschedule
    {
        public int SlNo { get; set; }
        public int? Wwid { get; set; }
        public string SId { get; set; }
        public int? ShId { get; set; }
        public int? WoId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Shift S { get; set; }
        public virtual Schedule Sh { get; set; }
        public virtual WeekOff Wo { get; set; }
        public virtual Users Ww { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
