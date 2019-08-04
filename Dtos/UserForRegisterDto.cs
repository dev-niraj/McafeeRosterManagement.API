namespace McafeeRosterManagement.API.Dtos
{
    public class UserForRegisterDto
    {
        public int Wwid { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TId { get; set; }
        public string Type { get; set; }
        public long PhoneNo { get; set; }
        public string Status { get; set; }
        public int BuId { get; set; }
    }
}