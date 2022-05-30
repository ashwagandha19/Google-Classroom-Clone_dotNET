using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Models
{
    public class Enrollment
    {
        public Guid Id { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
