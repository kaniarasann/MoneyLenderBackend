using System;
namespace MoneyLenderBackend.DomainModel {
    public class User {
        public string Id { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public virtual Login Login {get;set;}
    }

}