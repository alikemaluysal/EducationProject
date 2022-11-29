using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Takes : Entity
    {
        public Guid StudentId { get; set; }
        public virtual Student Student { get; set; }
        public Guid CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
