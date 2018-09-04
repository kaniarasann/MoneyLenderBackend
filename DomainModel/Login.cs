using System;
namespace MoneyLenderBackend.DomainModel {
        public class Login {
            public string Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public bool IsActive { get; set; }
            public Int16 InvalidAttempts { get; set; }
            public string UserId{get;set;}
            public virtual User User{get;set;}
        }
}