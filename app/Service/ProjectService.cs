using System;
using System.Collections.Generic;
using System.Text;
using ProjectManagementSystem.Repository.Abstractions;
using ProjectManagementSystem.Models;

namespace ProjectManagementSystem.Service
{
    public class ProjectService
    {
        IProjectRepository projectRepository;
        IGradingRepository gradingRepository;

        public ProjectService(IProjectRepository projectRepository, IGradingRepository gradingRepository)
        {
            this.gradingRepository = gradingRepository;
            this.projectRepository = projectRepository;
        }

        public Project GetProjectById(Guid projectId)
        {
            //if (projectId == null)
            //{
            //    throw new Exception("Null project id");
            //}

            return projectRepository.GetProjectById(projectId);

        }

        public IEnumerable<Project> GetAll()
        {
            return projectRepository.GetAll();
        }

        public void AddProject(string title)
        {

            projectRepository.Add(new Project()
            {
                Id = Guid.NewGuid(),
                Project_Title = title
            });
        }

        public void AddGrade(int grade)
        {

            gradingRepository.Add(new Grading()
            {
                Id = Guid.NewGuid(),
                Grade = grade,
            });
        }


    }
}
