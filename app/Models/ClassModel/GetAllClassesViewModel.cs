using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystem.Models.ClassModel
{
    public class GetAllClassesViewModel
    {
        public IEnumerable<Class> Classes { get; set; }
        //public string ClassName { get; set; }
        //public string StudentEmail { get; set; }
    }
}
