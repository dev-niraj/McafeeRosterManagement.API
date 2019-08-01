using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McafeeRosterManagement.API.Models
{
    public partial class CHoliday
    {
        [Key]
        public int HId { get; set; }
        public string HName { get; set; }
        public DateTime? HDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
