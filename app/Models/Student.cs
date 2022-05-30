using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string University { get; set; }
        public string Section { get; set; }
        public string Email { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<Grading> Gradings { get; set; }
    }
}
