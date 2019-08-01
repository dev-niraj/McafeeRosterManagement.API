using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McafeeRosterManagement.API.Models
{
    public partial class Oncall
    {
        [Key]
        public int SlNo { get; set; }
        public int? Wwid { get; set; }
        public int? TId { get; set; }
        public DateTime? OnDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Team T { get; set; }
        public virtual Users Ww { get; set; }
    }
}
