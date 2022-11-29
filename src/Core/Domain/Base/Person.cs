using Domain.Base;
using Domain.Enums;

namespace Domain.Entities
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SocialSecurityNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        //TODO public Address Address { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
    }
}
