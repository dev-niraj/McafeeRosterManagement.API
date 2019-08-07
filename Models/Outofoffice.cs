using System;
using System.Collections.Generic;

namespace McafeeRosterManagement.API.Models
{
    public partial class Outofoffice
    {
        public int SlNo { get; set; }
        public int? Wwid { get; set; }
        public DateTime? Odate { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Users Ww { get; set; }
    }
}
