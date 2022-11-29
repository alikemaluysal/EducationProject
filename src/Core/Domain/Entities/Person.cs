using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person : Entity
    {
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
