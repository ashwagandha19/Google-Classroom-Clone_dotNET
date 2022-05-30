using ProjectManagementSystem.Models;
using ProjectManagementSystem.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagementSystem.Repository
{
    public class EnrollRepository : BaseRepository<Enrollment>, IEnrollRepository
    {
        public EnrollRepository(PmsDbContext dbContext) : base(dbContext)
        {

        }


        public Enrollment GetEnrollByClassId(Guid classId)
        {
            var oneClass = dbContext.Enrollments.Where(p => p.Classes.Any(project => project.Id == classId)).SingleOrDefault();
            return oneClass;
        }
    }
}
