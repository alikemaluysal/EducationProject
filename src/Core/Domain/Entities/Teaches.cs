using Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Teaches : Entity
    {
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public int InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}
