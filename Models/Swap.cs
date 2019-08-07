using System;
using System.Collections.Generic;

namespace McafeeRosterManagement.API.Models
{
    public partial class Swap
    {
        public int SlNo { get; set; }
        public int? FromWwid { get; set; }
        public int? ToWwid { get; set; }
        public int? TId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Users FromWw { get; set; }
        public virtual Team T { get; set; }
        public virtual Users ToWw { get; set; }
    }
}
