using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectManagementSystem.Repository.Abstractions;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.Repository
{
    public class ProjectRepository : BaseRepository<Project>, IProjectRepository
    {
        public ProjectRepository(PmsDbContext dbContext) : base(dbContext)
        {

        }

        public Project GetProjectById(Guid projectId)
        {
            return dbContext.Projects.Where(project => project.Id == projectId).SingleOrDefault();

        }
    }
}