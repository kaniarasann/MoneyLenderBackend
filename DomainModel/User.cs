using System;

namespace MoneyLenderBackend.DomainModel
{
    public class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Firstname { get; set; }
        public string Lastname {get;set;}
        public string Address{get;set;}
    }
}