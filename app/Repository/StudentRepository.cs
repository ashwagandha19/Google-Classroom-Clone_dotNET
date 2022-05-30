using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ProjectManagementSystem.Repository.Abstractions;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.Repository

{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(PmsDbContext dbContext) : base(dbContext)
        {

        }

        public Student GetStudentByEmail(string Email)
        {
            var oneStudent = dbContext.Students.Where(student => student.Email == Email).SingleOrDefault();
            return oneStudent;
        }

        public Student GetStudentById(Guid Id)
        {
            var oneStudent = dbContext.Students.Where(student => student.Id == Id).SingleOrDefault();
            return oneStudent;
        }

        public Student GetStudentByName(string name)
        {
            var oneClass = dbContext.Students.Where(p => p.Name == name).SingleOrDefault();
            return oneClass;


        }


    }
}