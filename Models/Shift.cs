using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McafeeRosterManagement.API.Models
{
    public partial class Shift
    {
        public Shift()
        {
            Aschedule = new HashSet<Aschedule>();
        }

        [Key]
        public string SId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual ICollection<Aschedule> Aschedule { get; set; }
    }
}
