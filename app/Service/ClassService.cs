﻿using ProjectManagementSystem.Models;
using ProjectManagementSystem.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Service
{
    public class ClassService
    {
        IClassRepository classRepository;

        public ClassService(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        public Class GetClassByProjectId(Guid projectId)
        {
            if (projectId == null)
            {
                throw new Exception("Null project id");
            }

            return classRepository.GetClassByProjectId(projectId);

        }
        public Class GetClassById(Guid classId)
        {
            //var oneClass = dbContext.Classes.Where(p => p.Id == classId).SingleOrDefault();
            return classRepository.GetClassById(classId);
        }

        public IEnumerable<Class> GetAll()
        {
            return classRepository.GetAll();
        }

        //Add trip
        public void AddClass(string subjectTitle, string description)
        {

            classRepository.Add(new Class()
            {
                Id = Guid.NewGuid(),
                Subject_Title = subjectTitle,
                Description = description,
            });
        }



        public string GetClassName(Guid id)
        {
            var classObj = classRepository.GetClassById(id);
            return classObj.Subject_Title;
        }

        public Class GetClassByName(string name)
        {
            // var oneClass = dbContext.Classes.Where(p => p.Subject_Title == name).SingleOrDefault();
            return classRepository.GetClassByName(name);


        }

        public void DeleteClass(Guid classId)
        {
            var oneClass = classRepository.GetClassById(classId);
            classRepository.Delete(oneClass);
        }

        //public void UpdateClass(Guid classId, string subjectTitle, string description)
        //{
        //    //Guid tripIdGuid = Guid.Empty;
        //    //if (!Guid.TryParse(classId, out classIdGuid))
        //    //{
        //    //    throw new Exception("Invalid Guid Format");
        //    //}

        //    var class = tripRepository.GetTripBy(tripId);
        //    class.Subject_title = subjectTitle;
        //    class.Description = description;
        //   
        //    classRepository.Update(trip);
        //}
    }
}
