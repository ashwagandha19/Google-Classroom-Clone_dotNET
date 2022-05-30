using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Repository.Abstractions
{
    public interface IClassRepository : IRepository<Class>
    {
        Class GetClassByProjectId(Guid projectId);

        Class GetClassById(Guid classId);

        Class GetClassByName(string name);

    }
}
