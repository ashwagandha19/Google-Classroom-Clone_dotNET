using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Repository.Abstractions
{
    public interface ITeacherRepository : IRepository<Teacher>
    {
        Teacher GetTeacherById(Guid teacherId);

        Teacher GetTeacherByEmail(string teacherEmail);

    }
}
