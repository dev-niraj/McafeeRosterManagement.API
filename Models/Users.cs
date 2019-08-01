using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace McafeeRosterManagement.API.Models
{
    public partial class Users
    {
        public Users()
        {
            Aschedule = new HashSet<Aschedule>();
            Oncall = new HashSet<Oncall>();
            Outofoffice = new HashSet<Outofoffice>();
            SwapFromWw = new HashSet<Swap>();
            SwapToWw = new HashSet<Swap>();
            UsersHistory = new HashSet<UsersHistory>();
        }

        [Key]
        public int Wwid { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? TId { get; set; }
        public string Type { get; set; }
        public long? PhoneNo { get; set; }
        public string Status { get; set; }
        public int? BuId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public virtual Businessunit Bu { get; set; }
        public virtual Team T { get; set; }
        public virtual ICollection<Aschedule> Aschedule { get; set; }
        public virtual ICollection<Oncall> Oncall { get; set; }
        public virtual ICollection<Outofoffice> Outofoffice { get; set; }
        public virtual ICollection<Swap> SwapFromWw { get; set; }
        public virtual ICollection<Swap> SwapToWw { get; set; }
        public virtual ICollection<UsersHistory> UsersHistory { get; set; }
    }
}
