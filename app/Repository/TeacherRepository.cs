using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using ProjectManagementSystem.Repository.Abstractions;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.Repository
{
    public class TeacherRepository : BaseRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(PmsDbContext dbContext) : base(dbContext)
        {

        }

        public Teacher GetTeacherByEmail(string teacherEmail)
        {
            return dbContext.Teachers
                .Where(teacher => teacher.Email == teacherEmail)
                .SingleOrDefault();
        }

        public Teacher GetTeacherById(Guid userId)
        {
            return dbContext.Teachers

                           .Where(teacher => teacher.Id == userId)

                           .SingleOrDefault();
        }


    }
}
