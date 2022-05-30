using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Repository.Abstractions
{
    public interface IProjectRepository : IRepository<Project>
    {
        Project GetProjectById(Guid projectId);

    }
}
