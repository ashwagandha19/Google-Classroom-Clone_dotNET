using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Repository.Abstractions
{
    public interface IEnrollRepository : IRepository<Enrollment>
    {
        Enrollment GetEnrollByClassId(Guid classId);

    }
}
