using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Repository.Abstractions
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetStudentById(Guid studentId);
        Student GetStudentByName(string name);

        Student GetStudentByEmail(string Email);

    }
}
